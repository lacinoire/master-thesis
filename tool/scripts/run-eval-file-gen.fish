# run in samples folder to generate all eval files from log samples in the respective "failed" folders

for lang in (ls .)
  cd $lang
  for repo in (ls .)
    cd $repo"/failed"
    fish ~/.config/fish/eval-files.fish
  end
end