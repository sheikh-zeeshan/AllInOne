Objective of Movie Rental System

Movie Rental System is a web based application which has been developed over PHP and MySQL and runs on WAMP, XAMP or Apache2 server.. The main modules of the project is Movie,Customer,Payment,Seats,Shows. Admin user can manage all the operations of Seats,Shows,Movie,Booking,Customer and their details. Admin can create different type of reports of Movie,Customer,Payment,Seats,Shows according to their choise and filters. You can Download PHP and MySQL Project Movie Rental System with source code and database from this site. We also provide Project Report of Movie Rental System.

Functionalities and their descriptions of Movie Rental System are as follows:

You can search records on various criterias. Such as Movie, Payment, Seats, Shows
Create, read, update and delete (CRUD) application has been implemented on Movie,Customer,Payment,Seats,Shows
Keep the track logs of Customer, Booking, Seats ect
Advance search has been implemented on Customer,Booking, Seats
You can see all the details of the Movie, Payment, Booking, Seats
All the modules Booking, Seats, Customer,Shows, Movie are inter related and tightly coupled
It deals with monitoring the information and transactions of Seats.
All the Customer,Booking, Seats modules has their unique record ID for fast transactions and searching
Editing, adding and updating of Records is improved which results in proper resource management of Movie data.


Modules of Movie Rental System and their descriptions:
Movie Module : Manage all the operations of Movie
Customer Module : Manage all the operations of Customer
Booking Module : Manage all the operations of Booking
Payment Module : Manage all the operations of Payment
Seats Module : Manage all the operations of Seats
Shows Module : Manage all the operations of Shows


Classes and their methods of Movie Rental System:
Movie Methods : addMovie(), editMovie(), deleteMovie(), updateMovie(), saveMovie(), searchMovie()
Customer Methods : addCustomer(), editCustomer(), deleteCustomer(), updateCustomer(), saveCustomer(), searchCustomer()
Booking Methods : addBooking(), editBooking(), deleteBooking(), updateBooking(), saveBooking(), searchBooking()
Payment Methods : addPayment(), editPayment(), deletePayment(), updatePayment(), savePayment(), searchPayment()
Seats Methods : addSeats(), editSeats(), deleteSeats(), updateSeats(), saveSeats(), searchSeats()
Shows Methods : addShows(), editShows(), deleteShows(), updateShows(), saveShows(), searchShows()
Database tables and attributes of the Movie Rental System:
Movie Entity : Attributes of Movie are movie_id, movie_name, movie_language, movie_type, movie_hour, movie_description
Customer Entity : Attributes of Customer are customer_id, customer_name, customer_mobile, customer_email, customer_username, customer_password, customer_address
Booking Entity : Attributes of Booking are booking_id, booking_title, booking_type, booking_ticket, booking_date, booking_description
Payment Entity : Attributes of Payment are payment_id, payment_customer_id, payment_date, payment_amount, payment_description
Seats Entity : Attributes of Seats are seat_id, seat_movie_id, seat_customer_id, seat_number, seat_type, seat_description
Shows Entity : Attributes of Shows are show_id, show_name, show_type, show_time, show_date, show_description


Database definition of Movie Rental System:
The details of Movie is store into the Movie tables respective with all tables
Each entity (Shows, Booking, Seats, Customer, Movie) contains primary key and unique keys.
The entity Booking, Seats has binded with Movie, Customer entities with foreign key
There is one-to-one and one-to-many relationships available between Seats, Payment, Shows, Movie
All the entities Movie, Seats, Booking, Shows are normalized and reduce duplicacy of records
We have implemented indexing on each tables of Movie Rental System tables for fast query execution.


Super admin functionality of Movie Rental System:
Admin can add, edit, delete and view the records of Movie, Seats, Booking, Shows
Admin can manage all the details of Customer, Booking, Payment, Seats
Admin can also generate reports of Movie, Customer, Booking, Payment
Admin can search the details of Movie, Seats, Booking, Shows
Admin can apply different level of filters on report of Movie, Booking, Shows
Admin can tracks the detailed information of Seats, Shows, Movie, Customer


Report of Movie Rental System:
Generates the report on Booking,Payment,Movie,Customer,Seats,Shows,
Payment,Seats,Shows has been integrated with the dynamic filter. So you can filter the records run time
You can also import the report data into PDF of Payment,Seats,Shows
Excel Sheet report has also been integrated for Customer,Payment,Shows
You can create the CSV reports for Movie,Seats,Booking


Limitation of Movie Rental System
Run time report generation is not available in Movie Rental System.
We have not implemented the dynamic report for Movie,Payment,Seats,Customer,Booking,Shows
This project Movie Rental System has not been developed on Model View Controller architecture, so its very complex to manage
Batch mode execution for Off-line reports of Movie, Payment, Shows cannot be generated.
Crystel report has not been integrated


Input Data and Validation of Movie Rental System
We have added all the validations for input value on the modules Movie,Customer,Booking
Payment,Seats,Shows can not be submited without filling all the inout fields
Duplicate values testing has been implemented on Movie,Booking,Shows
CSRF token has also been implemented on Payment,Customer,Movie, Seats,Shows
All the Movie,Payment,Seats,Customer,Booking,Shows has integrated with captcha for spam protections
Access level validation has been implemented on Shows,Seats,Payment
Number and character validation has also been implemented on Booking,Seats,Movie


https://www.infoq.com/articles/repository-advanced/