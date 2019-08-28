# run in samples folder to generate all eval files from log samples in the respective "failed" folders

for lang in Elixir Erlang Haskell Lisp Perl PowerShell R TeX
  for repo in (ls $lang/.)
    pushd $lang"/"$repo"/failed"
    fish /Users/Laci/Documents/Delft/master-thesis/tool/scripts/gen-exampleset-file.fish
    popd
  end
end