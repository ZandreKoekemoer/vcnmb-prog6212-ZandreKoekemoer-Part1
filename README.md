# Question 1
The Contract Monthly Claim System is developed with a straightforward and open interface that lecturers, program coordinators, and academic managers may easily navigate.
The colour scheme will be mostly straightforward, with white backgrounds and blue panels such as by the navigation also make use of bootstrap to give a cleaner look and feel. Blue buttons will be used for important duties such as filing or approving claims and red buttons for rejecting claims.
This keeps the design clean and professional while being simple to implement in MVC project. The font will be a standard option  because these are typical system fonts that are easy to read.
Navigation will be straightforward, with a top bar including connections to each role. Each page will have the same colors, buttons, and font style, making it easier to use and less likely to cause confusion.

Each role’s view:

•	Lecturers can file monthly claims, upload supporting documentation, and check the progress of their claims. The interface is straightforward, with forms for inputting hours worked, uploading documents, and filing claims in a single click.

•	Coordinators can examine claims filed by lecturers, approve or reject them, and provide comments as needed. The interface displays all pending claims in a list manner, complete with approval action buttons.

•	Academic Manager: Managers approve claims after the coordinator has evaluated them. They can also read summaries or reports for all claims. The design features a basic dashboard that displays claims awaiting approval, approved claims, and any comments provided by coordinators

The main tables in our database are Lecturer,Claims,Documents,ProgCoordinator and the Manager. The Lecturer table contains information such as ID, name, email, and hourly rate. 
The Claim table is linked to the Lecturer and includes details such as hours worked, total amount, claim status, and the date the claim  was submitted.
Documents store file paths for uploaded documents that have links with specific claims. The ProgCoordinator and Manager tables contain information about users who examine and approve claims. 
The relationships are basic and easy to understand, making the database useful at this point of the project.

Assumptions:
•	Lecturers submit  their hours and valid documents.
•	Programme Coordinators and Academic Managers review claims and either Approve or Reject
•	All users have the necessary computer literacy and internet access to use the system.
Constraints
•	The system will  be developed using  MVC.
•	Part 1 is a prototype only, so it does not include backend functionality yet.
•	The project must be completed within the semester timeframe, limiting the scope of features.

# Question 2
 <img width="837" height="741" alt="image" src="https://github.com/user-attachments/assets/0dd5a079-0ad9-4dff-b3b8-390edc8f6783" />

# Question 3
<img width="695" height="545" alt="image" src="https://github.com/user-attachments/assets/98286c3d-abec-469d-bf73-36c5108f9221" />

# Question 4
<img width="1883" height="869" alt="Screenshot 2025-09-17 191428" src="https://github.com/user-attachments/assets/bf046efb-964c-41b7-b092-9161e83fca49" />
<img width="1897" height="999" alt="Screenshot 2025-09-17 230747" src="https://github.com/user-attachments/assets/62f473d9-7f2c-4031-824d-1d96e78966b1" />
<img width="1916" height="915" alt="Screenshot 2025-09-17 230758" src="https://github.com/user-attachments/assets/dc86656a-1627-4c5c-b4a2-da9c9a965110" />

# Reference

Bootstrap. 2023. Bootstrap 5 Documentation.
Available at:
<https: //getbootstrap.com/docs/5.3/getting-started/introduction />
[Accessed 16 September 2025].
