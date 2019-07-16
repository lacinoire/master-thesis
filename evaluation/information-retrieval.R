library(dplyr)


main_path <<- "/Users/Laci/Documents/Delft/master-thesis"
sample_path <<-
  paste(main_path, "/pbe-extraction-buildlogs/samples", sep = "")

## load other modules
source(paste(main_path, "/evaluation/utilities.R", sep = ""))
source(paste(main_path, "/evaluation/example-set.R", sep = ""))

## load example set
path <- 'android-failure.xml'
#path <- 'travis-worker-short.xml'
examples <- get_exampleset(path)

## select on which examples to train / test
train_examples <- examples[c(1, 3:4), ]
test_examples <- examples[c(2:2), ]

# we collect all line which contain (parts)
# of the output the extraction should yield
# (defined in the training examples)

train_lines <- get_ided_line_samples(train_examples)
test_lines <- get_ided_line_samples(test_examples, only_output_lines = FALSE)

total_lines <- rbind(train_lines, test_lines)

prep_fun <- identity
tok_fun <- word_tokenizer

it_total <- itoken(total_lines$lines, preprocessor = prep_fun, tokenizer = tok_fun, ids = total_lines$id)
it_train <- itoken(train_lines$lines, preprocessor = prep_fun, tokenizer = tok_fun, ids = train_lines$id)
it_test <- itoken(test_lines$lines, preprocessor = prep_fun, tokenizer = tok_fun, ids = test_lines$id)


## prepare vocabulary
# todo n-grams?
vocab <- create_vocabulary(it_total)
pruned_vocab <- prune_vocabulary(vocab, term_count_min = 2, doc_proportion_max = 0.7, doc_proportion_min = 0)
vectorizer <- vocab_vectorizer(pruned_vocab)

dtm_train <- create_dtm(it_train, vocab)
dtm_test <- create_dtm(it_test, vocab)


## tf-idf transformation
tfidf = TfIdf$new()
# fit model to train data and transform train data with fitted model
dtm_train_tfidf = fit_transform(dtm_train, tfidf)
# tfidf modified by fit_transform() call!
# apply pre-trained tf-idf transformation to test data
dtm_test_tfidf  = create_dtm(it_test, vectorizer) %>% 
  transform(tfidf)

test_train_similarity <- sim2(dtm_test_tfidf, dtm_train_tfidf, method = "cosine", norm = "l2")

#similarity_frame <- filter(as.data.frame(test_train_similarity), any_vars(. > 0))

print(dim(test_train_similarity))
print(test_train_similarity[1:5, 1:8])

similarity_sums <- apply(test_train_similarity, 1, sum)
filtered_similarity_sums <- similarity_sums[similarity_sums > 0.5]
# print(head(similarity_sums))
# print(str(filtered_similarity_sums))
# print(head(filtered_similarity_sums))
# avg <- mean(filtered_similarity_sums)
# print(avg)
print(filtered_similarity_sums)
plot(filtered_similarity_sums)

print(names(filtered_similarity_sums))
extracted_lines <- subset(test_lines, id %in% names(filtered_similarity_sums))

print(extracted_lines)