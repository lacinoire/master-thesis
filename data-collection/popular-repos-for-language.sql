with popular_projects as (
  select u.login, p.name, p.language, count(*) as watch_count
  from `ghtorrent-bq.ght_2018_04_01.projects` p,`ghtorrent-bq.ght_2018_04_01.users` u, `ghtorrent-bq.ght_2018_04_01.watchers` w
  where
      p.forked_from is null and
      p.deleted is false and
      w.repo_id = p.id and
      u.id = p.owner_id
  group by p.id, u.login, p.name, p.language
  having count(*) > 50
  order by count(*) desc
),

rank_watches_popular_languages as (
  select p.login, p.name, p.watch_count, p.language, 
    ROW_NUMBER() over (partition by p.language order by p.watch_count desc) as rank
  from popular_projects p
  where p.language = "?language?"
),

tenth_most_watched_per_popular_language as (
  select r.*
  from rank_watches_popular_languages r
  where r.rank < ?rank-upper-bound? and r.rank > ?rank-lower-bound?
)

select *
from tenth_most_watched_per_popular_language