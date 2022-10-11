
use Library
select * from Member
select * from Issue
select * from Book

--1)List the various categories and count of books in each category.
select distinct Category, count(Book_No) from Book group by Category

-- 2)List the book_No and the number of times the book is issued in the descending order of count.
select b.Book_No ,count(i.member_id) from Book b inner join Issue i
on b.Book_No = i.Book_No
group by B.Book_No