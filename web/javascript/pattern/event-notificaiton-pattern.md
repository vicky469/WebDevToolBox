## Different types of event-driven architectures

1. Message Queueing  
   Events are processed by one consumer.

   Use cases:

   - audit log

2. Pub/Sub  
   Separation between processing and coordination.
   Many consumers can subscribe to particular types of events and consume them.
   - callback (notify)
   - subscription
   - unsubscribe

### Challenges

#### 1. Service dependencies => use SAGA to solve

#### 2. Data replication in distributed systems

#### 3. Callback pressure

"Callback pressure" refers to the load or stress placed on a system (the producer) when it has to handle multiple callbacks from other systems (the consumers).

In the context of the event notification pattern, when an event occurs, the producer sends a notification to the consumers. Each consumer might then make a callback to the producer to get more information or to perform some action.

If there are many consumers, or if the consumers make many callbacks, this can put a lot of pressure on the producer. This is especially true if the callbacks happen all at once or in quick succession.

For example, if an event is consumed by nine consumers, that could mean nine incoming calls to the producer almost at the same time. This could potentially overload the producer.

The situation can get even worse if a consumer has been down and is catching up on events, as it might make a large number of callbacks in a short period of time.

Solution:

1. Enough resources to be able to scale up as needed
2. rate-limiting to prevent the producer from being overwhelmed.

#### 4. Network failure

### Event processing challenges

#### 1. Duplicate processing

most event brokers offer at-least-once delivery semantics as the default behaviour.

dedup solution:

#### 2. out of order processing

Not a concern to events that have no direct relationship with others.

But when it is a concern.
Two solutions:

1. Using a single consumer, in combination with first-in-first-out (FIFO) delivery. This approach protects the global order of all messages, but obviously doesn’t scale well.
2. Use an event `broker` that supports `FIFO` and apply a partitioned consumption pattern instead of a competing consumers setup.

Related messages are always routed to the same consumer based on a routing key attribute. In the previous example with the ProductCreated and ProductUpdated events the unique ID of the product would be the routing key. While partitioned consumption doesn’t protect the global order of all messages, it does protect order for related messages, which is what matters in most cases. And the big benefit is that it’s much more scalable. There are solutions out there that provide order processing guarantees, which can help with this. This will be covered in an upcoming example.

### Examples

#### customerProfileUpdated

metadata example

```
{
    "specversion" : "1.0",
    "type" : "com.example.orderPlaced",
    "source" : "/order/v1/A001-1234-1234",
    "id" : "A001-1234-1234",
    "time" : "2020-12-15T00:00:00Z"
}

```

With a field that specifies which profile attributes changed. This would allow a consumer listening for those events, but only being interested in address changes, to decide if and how to respond to the event.

![alt text](https://miro.medium.com/v2/resize:fit:720/format:webp/1*VhHfoFl54K2-bsH3r2Cgnw.png)

References:
[1]https://medium.com/geekculture/the-event-notification-pattern-a62d48519107
