# Api.MyKitchenRoutingSystem
I assumed that I was supposed to do an API to connect the waiter (or client, directly) with the restaurant, sending the order to the respective kitchen area that is specialized in preparing that order.
The API supports the create, read and delete of the food requests, that is ordered by ID. The workers of the kitchen must prepare the requests from lowest identifier to highest. 

I utilized the onion architecture to develop this solution.
The Unit Tests ensure that the business rules work. When you call for the requests in the salad kitchen, only salads will appear and, when it’s empty, it will warn you. 
