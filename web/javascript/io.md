A lot of web applications are just query a database and return the result.
So the question is how well the web framework is doing when these lines of codes are running.

```
var res = db.query("select * from t");
// use the result
```

We can't just wait for the database to respond.

There is a big difference between what happens inside your CPU, inside your memory, and what happens when you go to something outside of that.

If you go to a network, you have to do TCP connection to a different server, even if it is your same hosting center.It is millions of clock cycles instead of hundreds of clock cycles or tens of clock cycles.

![Image](https://i.gyazo.com/27384cd38551b0a39557d29ab1b9c993.png)

So you can't do nothing while waiting.
There are two solutions to address this issue:

1. operating system threads
1. event notification system

Let's look at the multi-threaded solution.
A look at two popular web servers - Apache and NGINX and see how they are doing IO.
What to measure?

- memory usage
- concurrency (request handling): How does each server handle a large number of simultaneous requests?
- CPU (time) usage: context switching between different threads

![Image](https://i.gyazo.com/42bf894315e11f7e510746bf3446e48d.png)

| Apache                                                                                                                                          | NGINX                               |
| ----------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------- |
| Use tons of memory (megabytes of memory) when you start getting a lot of clients if you have 3000 people like connecting to your Apache server. | Stays stable with a small footprint |
| Cause Apache use threads for each connection                                                                                                    | uses an event loop                  |

Apache uses OS threads.
Other threading system uses co-routines but it will need to require multiple execution stacks.

You could have the code like this where you make the query to the database, instead of waiting for the response inside that function, you give it a callback. When this happens your execution can run through the statement to make the request continue doing other things.

When the request comes back, millions and millions of clock cycles later, you can execute the callback. There is no machinery involved in this all your need is a pointer to that callback.

### Is this the best that can be done?

Can NOT use threads for each connection.

Right way to do is to use a single thread and an event loop.

References:  
[1] https://www.youtube.com/watch?v=EeYvFl7li9E&ab_channel=JSConf - 2012  
[2] https://github.com/martynsmith/node-irc
