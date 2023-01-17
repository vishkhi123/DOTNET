## Pizza Hub

## Document:
System Requirement Specification Document

## Title
System Requirement Specification for online pizza application

## Objective:
This document gives detailed functional and non-functional requirements for Pizza Hub – an online pizza ordering apllication.The purpose of 
this document is that the requirements mentioned in it should be utilized by software developer to implement the system.
The focus of this application is to create an “easy to use” website, which will provide easy solution to the customer to order the item he/she wants 
directly throughinternet without visiting the store.

## Scope
This system allows people to order their favorite delicious pizzas online from Pizza Hub application. With the help of this system customer
should able to order their favorite pizza’s from  Pizza Hub. The information about store and every pizza is also provided.

## Requirements 

Three types of users should be able to use the system: customer, employee and owner. 
Customers are users who visit the website and can create orders by selecting pizzas, 
selecting products and entering customer details. Employees are the group of users that work 
with the ordering system on a daily basis. Employees will have their own accounts to log on to. 
They are the ones responsible for processing orders.Customer users do not need a log in
to view pizza and non-pizza products but while adding to the cart customer need to log in.
employees who process orders can view the orders from the customer changes status of order.
The owner, or super user, has the ultimate control of the system, he can add products, as well as add, change, or delete employee accounts.

## Functional Requirements
### Customers 
- The user must be able to create a new order. 
- The user must be able to add a pizza to an order. 
- The user must be able to view a list of available non-pizza products. 
- The user must be able to add non-pizza products to an order. 
- The user must be able to see a list of pizzas and non-pizza products that are added to 
   the order. 
- the user must be able to see a list in sorted manner with respect to price.
- The user must be able to change the quantity of a pizza. 
- The user must be able to change the quantity of a non-pizza product. 
- The user must be able to delete a pizza from an order. 
- The user must be able to delete a non-pizza product from an order. 
- The user must be able to see the total price of an order. 
- The user must be able to add the name and address of the customer. 
- The user must be able to clear the current order to start a new one. 
- The user must be able to confirm the order. 
### Employees 
- The employee must be able to log in and out. 
- The employee must be able to view a list of available orders and their pizzas. 
- The employee must be able to mark orders as “prepared”. 
- The employee must be able to mark order as “delivered” 
- The employee must be able to mark order as “failure to deliver” 
- Only users with respective rights (employee) must be able to use all these “Employees” features. 

### Manager 
- The Manager must be able to log in and out. 
- The Manager must be able to add/delete/edit orders. 
- The Manager must be able to add/delete/edit ingredients. 
- The Manager must be able to add/delete/edit non-pizza products. 
- The Manager must be able to add/delete/edit other users. 
- The Manager must be able to view an order log. 
- Only users with respective rights (Manager) must be able to use all these “Manager” features.


## Non-Functional Requirement

As an operational requirement, the system will run as a database with a website as user 
interface. As performance requirement the system must be accessible 24 hours a day, seven 
days a week. Due to the nature of the system as an ordering website, the system must have a 
low response time, preferably shorter than second, with a maximum of five seconds. The 
exception is viewing order logs which could have a higher response time (of seconds) as the log 
increases in size over time. Due to the low complexity of the system, no problems with response 
time are expected. Customers who visit the website to order will get a sessionID for their visit, 
which is used to identify them while using the system. For every action they take, a timestamp 
is stored. From time to time a service on the server will scan sessionID’s and timestamps. 
SessionID’s which have not been active for more than three hours will be deleted along with the 
corresponding ordering information. 

### Interface Requirements 
#### GUI 
The user interface must be highly interactive so that all users may be able to operate the system 
as easily and fluently. GUI would be used for creating home page with navigation bar and other 
pages for respective categories. 
#### Software Interface 
The software interfaces required for this system are: 
 Internet connection 
 The PHP and MYSQL must be installed 
 Any browser 
### Performance Requirements 
The respond time must be less than 20 seconds. The full length pages should be displayed along 
with the images. 
### Design Constraints 
The system must be compatible with all the browsers. 

### Other Non-Functional Attributes 
#### Security 
The server-side security is needed to protect the system from hackers. 
#### Reliability 
The system should be highly reliable and it should generate all the updated information in 
correct order. 
#### Availability 
The system should be available 24*7. 
#### Maintainability 
The system should be maintainable in such a manner that if any new requirement occurs then it 
should be easily incorporated in an individual module. 
#### Reusability 
The system would be usable as long as people want to use it.
