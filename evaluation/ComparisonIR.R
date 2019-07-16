library(XML)
library(tm)
library(topicmodels)
library(jsonlite)
library(slam)
library(igraph)
library(stringr)
library(cluster)
library(snakecase)
library(stopwords)
library(NMOF)
library(xtable)



# source(paste(main_path, "/metaheuristics.R", sep=""))

# print(str(examples))

######## tdm for log file data #######
output_path <-
  paste(main_path, "/evaluation/split_samples", sep = "")

## 5. split the main file in separate paragraphs & files
# 5.1 Split text in sub-files
files <- examples$input_path
split_files(files, output_path)

## 6. create the corpus with textmatrix for example log files
tdm <- create_term_document_matrix(output_path)

######## tdm for labeled data #######
output_path_labeled_data <-
  paste(main_path, "/evaluation/labeled_samples", sep = "")
split_labeled_examples(examples, output_path_labeled_data)
tdm_l <- create_term_document_matrix(output_path_labeled_data)

# TODO: use filters function to filter out the lines labeled for extraction
# the function filters documents in the corpus
# idx <- meta(reuters, "id") =='237'&+   meta(reuters, "heading") =='INDONESIA SEEN AT CROSSROADS OVER ECONOMIC CHANGE'

evaluate_tdm <- function(tdm)
{
  # 7. Apply tf-idf weighting schema
  tdm2 <- weightSMART(tdm, "ntn")
  tdm$v <- as.integer(round(tdm2$v))
  #apply LDA to the term-by-document matrix
  print(tdm)
  ldm <- LDA(tdm, method="Gibbs", k = 3)  # k = num of topics
  pldm <- posterior(ldm)
  print(names(pldm))
}


# evaluate_tdm(tdm)
# evaluate_tdm(tdm_l)

library(text2vec)

#print(str(examples))

# print(str(train))
# print(str(test))

prep_fun = tolower
tok_fun = word_tokenizer

it_examples = itoken(examples$output, preprocessor = prep_fun, tokenizer = tok_fun, ids = examples$input_path)
it_train = itoken(train$output, preprocessor = prep_fun, tokenizer = tok_fun, ids = train$input_path)
it_test = itoken(test$output, preprocessor = prep_fun, tokenizer = tok_fun, ids = test$input_path)

#### prepare vocabulary

print(dtm_train)


print(dtm_train_tfidf)

dtrain_dtest_jac_sim = sim2(dtm_train, dtm_test, method = 'cosine', norm = 'l2')
print(dtrain_dtest_jac_sim)
