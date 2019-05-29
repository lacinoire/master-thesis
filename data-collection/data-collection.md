# Data collection for metamodel / example data

querying gh torrent like in travistorrent for popular projects (over 50 stars, not forked from somewhere, not deleted, ghtorrent dataset from 01042018)
aggregating by language: `queryA`

```sql
select t.language, count(*)
from (select u.login, p.name, p.language, count(*)
from `ghtorrent-bq.ght_2018_04_01.projects` p,`ghtorrent-bq.ght_2018_04_01.users` u, `ghtorrent-bq.ght_2018_04_01.watchers` w
where
    p.forked_from is null and
    p.deleted is false and
    w.repo_id = p.id and
    u.id = p.owner_id
group by p.id, u.login, p.name, p.language
having count(*) > 50
order by count(*) desc) t
where t.language is not null
group by t.language
order by count(*) desc
limit 30
```

|language|repo_count                          |
|--------|-----------------------------|
|        |40426                        |
|JavaScript|35483                        |
|Python  |16769                        |
|Java    |15177                        |
|PHP     |8224                         |
|Objective-C|7762                         |
|Ruby    |7270                         |
|C++     |7004                         |
|C       |6994                         |
|Go      |5711                         |
|C#      |4392                         |
|HTML    |4342                         |
|Shell   |4097                         |
|CSS     |3897                         |
|Swift   |3166                         |
|Scala   |1468                         |
|CoffeeScript|1266                         |
|Clojure |1146                         |
|TypeScript|1128                         |
|VimL    |1108                         |
|Rust    |990                          |
|Lua     |788                          |
|Haskell |757                          |
|Jupyter Notebook|733                          |
|Emacs Lisp|705                          |
|R       |643                          |
|Perl    |631                          |
|Elixir  |523                          |
|Erlang  |436                          |
|TeX     |400                          |
|PowerShell|374                          |

selecting most watched program for each of the 30 popular languages:

```sql
with popular_projects as (select u.login, p.name, p.language, count(*) as watch_count
from `ghtorrent-bq.ght_2018_04_01.projects` p,`ghtorrent-bq.ght_2018_04_01.users` u, `ghtorrent-bq.ght_2018_04_01.watchers` w
where
    p.forked_from is null and
    p.deleted is false and
    w.repo_id = p.id and
    u.id = p.owner_id
group by p.id, u.login, p.name, p.language
having count(*) > 50
order by count(*) desc),

popular_languages as (select t.language, count(*)
from popular_projects t
where t.language is not null
group by t.language
order by count(*) desc
limit 30),

most_watches_popular_languages as (select max(p.watch_count) as max_count, p.language
from popular_projects p, popular_languages l
where p.language = l.language
group by p.language)

select p.login, p.name, p.language, p.watch_count
from popular_projects p, most_watches_popular_languages l
where p.watch_count = l.max_count and p.language = l.language
order by p.watch_count desc
```

|login|name                         |language|watch_count                                  |
|-----|-----------------------------|--------|---------------------------------------------|
|FreeCodeCamp|freecodecamp                 |JavaScript|218166                                       |
|tensorflow|tensorflow                   |C++     |97842                                        |
|twbs |bootstrap                    |CSS     |74394                                        |
|robbyrussell|oh-my-zsh                    |Shell   |72362                                        |
|facebook|react-native                 |Java    |64194                                        |
|torvalds|linux                        |C       |55361                                        |
|vinta|awesome-python               |Python  |48856                                        |
|Microsoft|vscode                       |TypeScript|48445                                        |
|Atom |atom                         |CoffeeScript|46772                                        |
|FortAwesome|Font-Awesome                 |HTML    |43429                                        |
|docker|docker                       |Go      |43421                                        |
|rails|rails                        |Ruby    |43320                                        |
|laravel|laravel                      |PHP     |36504                                        |
|rust-lang|rust                         |Rust    |29168                                        |
|Alamofire|Alamofire                    |Swift   |27610                                        |
|tonsky|FiraCode                     |Clojure |22298                                        |
|aymericdamien|TensorFlow-Examples          |Jupyter Notebook|21636                                        |
|neovim|neovim                       |VimL    |20893                                        |
|shadowsocks|shadowsocks-windows          |C#      |20128                                        |
|rs   |SDWebImage                   |Objective-C|19750                                        |
|apache|spark                        |Scala   |17397                                        |
|exacity|deeplearningbook-chinese     |TeX     |16868                                        |
|jcjohnson|neural-style                 |Lua     |16167                                        |
|syl20bnr|spacemacs                    |Emacs Lisp|15439                                        |
|elixir-lang|elixir                       |Elixir  |13255                                        |
|begriffs|postgrest                    |Haskell |10942                                        |
|cmderdev|cmder                        |PowerShell|9438                                         |
|erlang|otp                          |Erlang  |7149                                         |
|sitaramc|gitolite                     |Perl    |6460                                         |
|arielf|weight-loss                  |R       |3290                                         |
