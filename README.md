# System Integration Microservice Mini project
Our task was to create a microservice for a business with bookings so they can
collect feedback from customers. We have therefore made a survey application
as a REST API with the microservice architecture style.

## Example instructions
***Note*** These instructions are only an example. There are other ways to do the same.

## Questions
We have made 10 predefined questions the customers are asked. The administrators
can see some statistics regarding the answers from those. The questions are:

* Geographical location (country / city)
* Gender
* Age range (10-17, 18-25, 26-29, 30-39, 40-49, 50-59, 60+)
* How many adults (18+) was in your reservation?
* How many kids was in your reservation?
* How was the booking experience? (1-10)
* How satisfied were you with the staff at the hotel? (1-10)
* How satisfied were you with the food? (1-10)
* How satisfied were you with the cleaning? (1-10)
* Any other comments? (text they can fill in)

## Continous integration
We used Azure DevOps to set up continous integration. It runs on
https://suveyapp20191210122852.azurewebsites.net/

## Docker
We set up our system to run in a Docker container.
