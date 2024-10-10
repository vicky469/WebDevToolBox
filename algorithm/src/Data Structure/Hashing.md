Why hashing?
- fast retrieval

Hashing Definitions
- "Hashing is the transformation of a string of characters into a usually shorter fixed-length value or key that represents the original string." (http://searchsqlserver.techtarget.com/definition/hashing),
- "Hashing is one way to enable security during the process of message transmission when the message is intended for a particular recipient only... Hashing is also a method of sorting key values in a database table in an efficient manner.",(https://www.techopedia.com/definition/14316/hashing)
- "Hashing involves applying a hashing algorithm to a data item, known as the hashing key, to create a hash value." (https://en.wikibooks.org/wiki/A-level_Computing/AQA/Paper_1/Fundamentals_of_data_structures/Hash_tab...),
- "Hashing is one of the great ideas of computing and every programmer should know something about it." (http://www.i-programmer.info/babbages-bag/479-hashing.html)

Formally, a hash function can be described by the following two properties：
1. Property of Equality:
   if you have two identical house keys, they should both be able to open the same lock.
2. Property of Inequality:
   if you have two different house keys, it would be best if they open two different locks. However, in the world of hash functions, sometimes different keys can end up with the same hash value (this is known as a hash collision).

References:
[1] https://stepik.org/lesson/31372/step/2?unit=11687