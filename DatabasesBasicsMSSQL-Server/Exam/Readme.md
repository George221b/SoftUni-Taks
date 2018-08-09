<h1>Database Basics MS SQL Exam &ndash; 19 Feb 2017</h1>
<p>Exam problems for the <a href="https://softuni.bg/courses/databases-basics-ms-sql-server">&ldquo;Database Basics&rdquo; course @ SoftUni</a>. Submit your solutions in the SoftUni judge system at <a href="https://judge.softuni.bg/Contests/469/">https://judge.softuni.bg/Contests/469/</a>.</p>
<p><strong>Database Fundamentals MSSQL &ndash; Bakery</strong></p>
<p><em>Your friend is opening his &ldquo;bio&rdquo; bakery. Since he is a lucky one to have you as a friend/programmer you decide to take part of his new journey &ndash; selling healthy food to people. Based on his requirements you should create the initial database frame. Then you have to do some data manipulations. Finally, you have to do some work on the programmability part. </em></p>
<h1>Section 1. DDL (25 pts)</h1>
<p><strong><u>For this section put your queries in judge and use: &ldquo;<em>SQL Server run queries and check DB</em>&rdquo;.</u></strong></p>
<p>You have been given the E/R Diagram of the bakery:</p>
<p>Crate a database called <strong>Bakery</strong>. You need to create <strong>7 tables</strong>:</p>
<ul>
<li><strong>Products</strong> &ndash; contains information about the products that are being sold in our bakery.</li>
<li><strong>Ingredients</strong> &ndash; contains information about concrete fruits, vegetables, spices and so on. Has relation to both products and distributors.</li>
<li><strong>ProductsIngredients</strong> &ndash; mapping table between products and ingredients.</li>
<li><strong>Distributors</strong> &ndash; contains information about distributors &ndash; organizations that deliver ingredients.</li>
<li><strong>Customers</strong> &ndash; contains information about the customers that use our products.</li>
<li><strong>Countries</strong> &ndash; contains info for origin place (ingredients), general office(distributors) or homeland (customers).</li>
<li><strong>Feedbacks</strong> &ndash; contains information about the feedback that the customers give while evaluating some of the products</li>
</ul>
<p><strong>Customers</strong></p>
<table width="1391">
<tbody>
<tr>
<td width="250">
<p><strong>Column Name</strong></p>
</td>
<td width="425">
<p><strong>Data Type</strong></p>
</td>
<td>
<p><strong>Constraints</strong></p>
</td>
</tr>
<tr>
<td width="250">
<p>Id</p>
</td>
<td width="425">
<p>Integer from 0 to 2,147,483,647</p>
</td>
<td>
<p>Unique table identificator, Identity</p>
</td>
</tr>
<tr>
<td width="250">
<p>FirstName</p>
</td>
<td width="425">
<p>String up to 25 symbols, Unicode</p>
</td>
<td>
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="250">
<p>LastName</p>
</td>
<td width="425">
<p>String up to 25 symbols, Unicode</p>
</td>
<td>
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="250">
<p>Gender</p>
</td>
<td width="425">
<p><strong>Character</strong> with <strong>exactly</strong> 1 symbol</p>
</td>
<td>
<p>Could be: '<em>M</em>' or '<em>F</em>'</p>
</td>
</tr>
<tr>
<td width="250">
<p>Age</p>
</td>
<td width="425">
<p>Integer from 0 to 2,147,483,647</p>
</td>
<td>
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="250">
<p>PhoneNumber</p>
</td>
<td width="425">
<p>String 10 <strong>characters</strong> long.</p>
</td>
<td>
<p>String length is <strong>exactly</strong> 10 <strong>chars</strong> long.</p>
</td>
</tr>
<tr>
<td width="250">
<p>CountryId</p>
</td>
<td width="425">
<p>Integer from 0 to 2,147,483,647</p>
</td>
<td>
<p>Relationship with table Countries</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p><strong>Feedbacks</strong></p>
<table width="1391">
<tbody>
<tr>
<td width="250">
<p><strong>Column Name</strong></p>
</td>
<td width="527">
<p><strong>Data Type</strong></p>
</td>
<td>
<p><strong>Constraints</strong></p>
</td>
</tr>
<tr>
<td width="250">
<p>Id</p>
</td>
<td width="527">
<p>Integer from 0 to 2,147,483,647</p>
</td>
<td>
<p>Unique table identificator, Identity</p>
</td>
</tr>
<tr>
<td width="250">
<p>Description</p>
</td>
<td width="527">
<p>String up to 255 symbols, Unicode</p>
</td>
<td>
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="250">
<p>Rate</p>
</td>
<td width="527">
<p><strong>Decimal</strong> number with two-digit precision</p>
</td>
<td>
<p>Rate is between 0 and 10</p>
</td>
</tr>
<tr>
<td width="250">
<p>ProductId</p>
</td>
<td width="527">
<p>Integer from 0 to 2,147,483,647</p>
</td>
<td>
<p>Relationship with table Products</p>
</td>
</tr>
<tr>
<td width="250">
<p>CustomerId</p>
</td>
<td width="527">
<p>Integer from 0 to 2,147,483,647</p>
</td>
<td>
<p>Relationship with table Customers</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p><strong>Products</strong></p>
<table width="1391">
<tbody>
<tr>
<td width="250">
<p><strong>Column Name</strong></p>
</td>
<td width="603">
<p><strong>Data Type</strong></p>
</td>
<td>
<p><strong>Constraints</strong></p>
</td>
</tr>
<tr>
<td width="250">
<p>Id</p>
</td>
<td width="603">
<p>Integer from 0 to 2,147,483,647</p>
</td>
<td>
<p>Unique table identificator, Identity</p>
</td>
</tr>
<tr>
<td width="250">
<p>Name</p>
</td>
<td width="603">
<p>String up to 25 symbols, Unicode</p>
</td>
<td>
<p>Unique</p>
</td>
</tr>
<tr>
<td width="250">
<p>Description</p>
</td>
<td width="603">
<p>String up to 250 symbols, Unicode</p>
</td>
<td>
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="250">
<p>Recipe</p>
</td>
<td width="603">
<p>String with unlimited number of symbols (<strong>max</strong>),</p>
<p>Unicode</p>
</td>
<td>
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="250">
<p>Price</p>
</td>
<td width="603">
<p>Decimal number used for <strong>money</strong> calculations</p>
</td>
<td>
<p><strong>Non-positive</strong> numbers are not allowed</p>
</td>
</tr>
</tbody>
</table>
<p><strong>&nbsp;</strong></p>
<p><strong>&nbsp;</strong></p>
<p><strong>Ingredients</strong></p>
<table width="1391">
<tbody>
<tr>
<td width="250">
<p><strong>Column Name</strong></p>
</td>
<td width="494">
<p><strong>Data Type</strong></p>
</td>
<td width="648">
<p><strong>Constraints</strong></p>
</td>
</tr>
<tr>
<td width="250">
<p>Id</p>
</td>
<td width="494">
<p>Integer from 0 to 2,147,483,647</p>
</td>
<td width="648">
<p>Unique table identificator, Identity</p>
</td>
</tr>
<tr>
<td width="250">
<p>Name</p>
</td>
<td width="494">
<p>String up to 30 symbols, Unicode</p>
</td>
<td width="648">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="250">
<p>Description</p>
</td>
<td width="494">
<p>String up to 200 symbols, Unicode</p>
</td>
<td width="648">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="250">
<p>OriginCountryId</p>
</td>
<td width="494">
<p>Integer from 0 to 2,147,483,647</p>
</td>
<td width="648">
<p>Relationship with table Countries</p>
</td>
</tr>
<tr>
<td width="250">
<p>DistributorId</p>
</td>
<td width="494">
<p>Integer from 0 to 2,147,483,647</p>
</td>
<td width="648">
<p>Relationship with table Distributors</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p><strong>ProductsIngredients</strong></p>
<table width="1391">
<tbody>
<tr>
<td width="250">
<p><strong>Column Name</strong></p>
</td>
<td width="425">
<p><strong>Data Type</strong></p>
</td>
<td width="716">
<p><strong>Constraints</strong></p>
</td>
</tr>
<tr>
<td width="250">
<p>ProductId</p>
</td>
<td width="425">
<p>Integer from 0 to 2,147,483,647</p>
</td>
<td width="716">
<p>Unique table identificator, Relationship with table Products</p>
</td>
</tr>
<tr>
<td width="250">
<p>IngredientId</p>
</td>
<td width="425">
<p>Integer from 0 to 2,147,483,647</p>
</td>
<td width="716">
<p>Unique table identificator, Relationship with table Ingredients</p>
</td>
</tr>
</tbody>
</table>
<p><strong>&nbsp;</strong></p>
<p><strong>Distributors</strong></p>
<table width="1391">
<tbody>
<tr>
<td width="250">
<p><strong>Column Name</strong></p>
</td>
<td width="482">
<p><strong>Data Type</strong></p>
</td>
<td width="660">
<p><strong>Constraints</strong></p>
</td>
</tr>
<tr>
<td width="250">
<p>Id</p>
</td>
<td width="482">
<p>Integer from 0 to 2,147,483,647</p>
</td>
<td width="660">
<p>Unique table identificator, Identity</p>
</td>
</tr>
<tr>
<td width="250">
<p>Name</p>
</td>
<td width="482">
<p>String up to 25 symbols, Unicode</p>
</td>
<td width="660">
<p>Unique</p>
</td>
</tr>
<tr>
<td width="250">
<p>AddressText</p>
</td>
<td width="482">
<p>String up to 30 symbols, Unicode</p>
</td>
<td width="660">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="250">
<p>Summary</p>
</td>
<td width="482">
<p>String up to 200 symbols, Unicode</p>
</td>
<td width="660">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="250">
<p>CountryId</p>
</td>
<td width="482">
<p>Integer from 0 to 2,147,483,647</p>
</td>
<td width="660">
<p>Relationship with table Countries</p>
</td>
</tr>
</tbody>
</table>
<p><strong>&nbsp;</strong></p>
<p><strong>Countries</strong></p>
<table width="1391">
<tbody>
<tr>
<td width="250">
<p><strong>Column Name</strong></p>
</td>
<td width="494">
<p><strong>Data Type</strong></p>
</td>
<td width="648">
<p><strong>Constraints</strong></p>
</td>
</tr>
<tr>
<td width="250">
<p>Id</p>
</td>
<td width="494">
<p>Integer from 0 to 2,147,483,647</p>
</td>
<td width="648">
<p>Unique table identificator, Identity</p>
</td>
</tr>
<tr>
<td width="250">
<p>Name</p>
</td>
<td width="494">
<p>String up to 50 characters, Unicode</p>
</td>
<td width="648">
<p>Unique</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
<h2>1.&nbsp;&nbsp; Database design</h2>
<p>Submit all of your create statements to Judge.</p>
<h1>Section 2. DML (15 pts)</h1>
<p><strong><u>For this section put your queries in judge and use: &ldquo;<em>SQL Server run skeleton, run queries and check DB</em>&rdquo;.</u></strong></p>
<p><strong><u>Before you start you have to import &ldquo;</u></strong><strong><em><u>Скелет</u></em><u>&rdquo;. If you have created the structure correctly the data should be successfully inserted.</u></strong></p>
<p>In this section, you have to do some data manipulations:</p>
<h2>2.&nbsp;&nbsp; Insert</h2>
<p>Let&rsquo;s <strong>insert</strong> some sample data into the database. Write a query to add the following records into the corresponding tables. All Id&rsquo;s should be auto-generated.</p>
<p><strong>Distributors</strong></p>
<table width="1391">
<tbody>
<tr>
<td width="317">
<p><strong>Name</strong></p>
</td>
<td width="164">
<p><strong>CountryId</strong></p>
</td>
<td width="253">
<p><strong>AddressText</strong></p>
</td>
<td>
<p><strong>Summary</strong></p>
</td>
</tr>
<tr>
<td width="317">
<p>Deloitte &amp; Touche</p>
</td>
<td width="164">
<p>2</p>
</td>
<td width="253">
<p>6 Arch St #9757</p>
</td>
<td>
<p>Customizable neutral traveling</p>
</td>
</tr>
<tr>
<td width="317">
<p>Congress Title</p>
</td>
<td width="164">
<p>13</p>
</td>
<td width="253">
<p>58 Hancock St</p>
</td>
<td>
<p>Customer loyalty</p>
</td>
</tr>
<tr>
<td width="317">
<p>Kitchen People</p>
</td>
<td width="164">
<p>1</p>
</td>
<td width="253">
<p>3 E 31st St #77</p>
</td>
<td>
<p>Triple-buffered stable delivery</p>
</td>
</tr>
<tr>
<td width="317">
<p>General Color Co Inc</p>
</td>
<td width="164">
<p>21</p>
</td>
<td width="253">
<p>6185 Bohn St #72</p>
</td>
<td>
<p>Focus group</p>
</td>
</tr>
<tr>
<td width="317">
<p>Beck Corporation</p>
</td>
<td width="164">
<p>23</p>
</td>
<td width="253">
<p>21 E 64th Ave</p>
</td>
<td>
<p>Quality-focused 4th generation hardware</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p><strong>Customers</strong></p>
<table width="1391">
<tbody>
<tr>
<td width="302">
<p><strong>FirstName</strong></p>
</td>
<td width="302">
<p><strong>LastName</strong></p>
</td>
<td>
<p><strong>Age</strong></p>
</td>
<td>
<p><strong>Gender</strong></p>
</td>
<td>
<p><strong>PhoneNumber</strong></p>
</td>
<td>
<p><strong>CountryId</strong></p>
</td>
</tr>
<tr>
<td width="302">
<p>Francoise</p>
</td>
<td width="302">
<p>Rautenstrauch</p>
</td>
<td>
<p>15</p>
</td>
<td>
<p>M</p>
</td>
<td>
<p>0195698399</p>
</td>
<td>
<p>5</p>
</td>
</tr>
<tr>
<td width="302">
<p>Kendra</p>
</td>
<td width="302">
<p>Loud</p>
</td>
<td>
<p>22</p>
</td>
<td>
<p>F</p>
</td>
<td>
<p>0063631526</p>
</td>
<td>
<p>11</p>
</td>
</tr>
<tr>
<td width="302">
<p>Lourdes</p>
</td>
<td width="302">
<p>Bauswell</p>
</td>
<td>
<p>50</p>
</td>
<td>
<p>M</p>
</td>
<td>
<p>0139037043</p>
</td>
<td>
<p>8</p>
</td>
</tr>
<tr>
<td width="302">
<p>Hannah</p>
</td>
<td width="302">
<p>Edmison</p>
</td>
<td>
<p>18</p>
</td>
<td>
<p>F</p>
</td>
<td>
<p>0043343686</p>
</td>
<td>
<p>1</p>
</td>
</tr>
<tr>
<td width="302">
<p>Tom</p>
</td>
<td width="302">
<p>Loeza</p>
</td>
<td>
<p>31</p>
</td>
<td>
<p>M</p>
</td>
<td>
<p>0144876096</p>
</td>
<td>
<p>23</p>
</td>
</tr>
<tr>
<td width="302">
<p>Queenie</p>
</td>
<td width="302">
<p>Kramarczyk</p>
</td>
<td>
<p>30</p>
</td>
<td>
<p>F</p>
</td>
<td>
<p>0064215793</p>
</td>
<td>
<p>29</p>
</td>
</tr>
<tr>
<td width="302">
<p>Hiu</p>
</td>
<td width="302">
<p>Portaro</p>
</td>
<td>
<p>25</p>
</td>
<td>
<p>M</p>
</td>
<td>
<p>0068277755</p>
</td>
<td>
<p>16</p>
</td>
</tr>
<tr>
<td width="302">
<p>Josefa</p>
</td>
<td width="302">
<p>Opitz</p>
</td>
<td>
<p>43</p>
</td>
<td>
<p>F</p>
</td>
<td>
<p>0197887645</p>
</td>
<td>
<p>17</p>
</td>
</tr>
</tbody>
</table>
<p><strong>&nbsp;</strong></p>
<h2>3.&nbsp;&nbsp; Update</h2>
<p>We&rsquo;ve decided to switch some of our ingredients to a local distributor. Update the table <strong>Ingredients</strong> and change the <strong>DistributorId</strong> of "Bay Leaf", "Paprika" and "Poppy" to 35. Change the <strong>OriginCountryId</strong> to 14 of all ingredients with <strong>OriginCountryId equal to</strong> 8.</p>
<h2>4.&nbsp;&nbsp; Delete</h2>
<p>Delete all <strong>Feedbacks</strong> which relate to <strong>Customer</strong> with <strong>Id</strong> 14 or to <strong>Product</strong> with <strong>Id</strong> 5.</p>
<h1>Section 3. Querying (40 pts)</h1>
<p><strong><u>You need to start with a fresh dataset, so recreate your DB and import the sample data again.</u></strong></p>
<p><strong><u>For this section put your queries in judge and use: &ldquo;<em>SQL Server prepare DB and run queries</em>&rdquo;.</u></strong></p>
<h2>5.&nbsp;&nbsp; Products by Price</h2>
<p>Select all <strong>products</strong> ordered by <strong>price</strong> (descending) then by name (ascending).</p>
<p>Required columns:</p>
<ul>
<li>Name</li>
<li>Price</li>
<li>Description</li>
</ul>
<p>Example:</p>
<table>
<tbody>
<tr>
<td width="203">
<p><strong>Name</strong></p>
</td>
<td width="170">
<p><strong>Price</strong></p>
</td>
<td width="466">
<p><strong>Description</strong></p>
</td>
</tr>
<tr>
<td width="203">
<p>Oxygen bread</p>
</td>
<td width="170">
<p>27.39</p>
</td>
<td width="466">
<p>Morbi ut odio.</p>
</td>
</tr>
<tr>
<td width="203">
<p>Pizza(small)</p>
</td>
<td width="170">
<p>27.27</p>
</td>
<td width="466">
<p>In sagittis dui vel nisl. Duis ac nibh.</p>
</td>
</tr>
</tbody>
</table>
<h2>6.&nbsp;&nbsp; Ingredients</h2>
<p>Find all ingredients coming from the countries with Id&rsquo;s of <strong>1, 10, 20</strong>. Order them by ingredient Id (ascending).</p>
<p>Required columns:</p>
<ul>
<li>Name</li>
<li>Description</li>
<li>OriginCountryId</li>
</ul>
<p>Example:</p>
<table>
<tbody>
<tr>
<td width="383">
<p><strong>Name</strong></p>
</td>
<td width="644">
<p><strong>Description</strong></p>
</td>
<td width="363">
<p><strong>OriginCountryId</strong></p>
</td>
</tr>
<tr>
<td width="383">
<p>Bouket</p>
</td>
<td width="644">
<p>Small bundle of herbs wrapped in a cheesecloth bag or tied together and added in soups to add flavor (parsley thyme and bay<em>&hellip;</em></p>
</td>
<td width="363">
<p>10</p>
</td>
</tr>
<tr>
<td width="383">
<p>Chives</p>
</td>
<td width="644">
<p>Belongs to the onion and leek family. Source of vitamin A.</p>
</td>
<td width="363">
<p>10</p>
</td>
</tr>
</tbody>
</table>
<h2>7.&nbsp;&nbsp; Ingredients from Bulgaria and Greece</h2>
<p>Select <strong>top 15</strong> ingredients coming from Bulgaria and Greece. Order them by ingredient name then by country name (both ascending).</p>
<p>Required columns:</p>
<ul>
<li>Name</li>
<li>Description</li>
<li>CountryName</li>
</ul>
<p>Example:</p>
<table>
<tbody>
<tr>
<td width="185">
<p><strong>Name</strong></p>
</td>
<td width="799">
<p><strong>Description</strong></p>
</td>
<td width="204">
<p><strong>CountryName</strong></p>
</td>
</tr>
<tr>
<td width="185">
<p>Anise</p>
</td>
<td width="799">
<p>The Greek name of anise &ldquo;glykanissos&rdquo; betrays its sweet character [gl&yacute;ka means sweetness]. It&rsquo;s best known use is in the famous ouzo, the Greeks&rsquo; favorite drink for the summertime.</p>
</td>
<td width="204">
<p>Greece</p>
</td>
</tr>
<tr>
<td width="185">
<p>Cardamom</p>
</td>
<td width="799">
<p>Cardamom has a strong piquant taste with lemon and pine notes. It is considered one of the most expensive spices and it is famous for its stimulating properties.</p>
</td>
<td width="204">
<p>Greece</p>
</td>
</tr>
</tbody>
</table>
<h2>8.&nbsp;&nbsp; Best Rated Products</h2>
<p>Select top 10 best rated products ordered by average rate (descending) then by amount of feedbacks (descending).</p>
<p>Required columns:</p>
<ul>
<li>Name</li>
<li>Description</li>
<li>AverageRate &ndash; average Rate for each product</li>
<li>FeedbacksAmount &ndash; number of feedbacks for each product</li>
</ul>
<p>Example:</p>
<table>
<tbody>
<tr>
<td width="263">
<p><strong>Name</strong></p>
</td>
<td width="228">
<p><strong>Description</strong></p>
</td>
<td width="252">
<p><strong>AverageRate</strong></p>
</td>
<td width="288">
<p><strong>FeedbacksAmount</strong></p>
</td>
</tr>
<tr>
<td width="263">
<p>Titanium breakfast</p>
</td>
<td width="228">
<p>Proin risus.</p>
</td>
<td width="252">
<p>9.920000</p>
</td>
<td width="288">
<p>1</p>
</td>
</tr>
<tr>
<td width="263">
<p>Octinoxate</p>
</td>
<td width="228">
<p>Octocrylene</p>
</td>
<td width="252">
<p>9.650000</p>
</td>
<td width="288">
<p>1</p>
</td>
</tr>
</tbody>
</table>
<h2>9.&nbsp;&nbsp; Negative Feedback</h2>
<p>Select all <strong>feedbacks</strong> alongside with the customers which gave them. Filter only feedbacks which have <strong>rate</strong> below <strong>5.0</strong>. Order results by ProductId (descending) then by Rate (ascending).</p>
<p>Required columns:</p>
<ul>
<li>ProductId</li>
<li>Rate</li>
<li>Description</li>
<li>CustomerId</li>
<li>Age</li>
<li>Gender</li>
</ul>
<p>Example:</p>
<table>
<tbody>
<tr>
<td width="184">
<p><strong>ProductId</strong></p>
</td>
<td width="103">
<p><strong>Rate</strong></p>
</td>
<td width="456">
<p><strong>Description</strong></p>
</td>
<td width="240">
<p><strong>CustomerId</strong></p>
</td>
<td width="156">
<p><strong>Age</strong></p>
</td>
<td width="251">
<p><strong>Gender</strong></p>
</td>
</tr>
<tr>
<td width="184">
<p>30</p>
</td>
<td width="103">
<p>2.04</p>
</td>
<td width="456">
<p>I did not like the product</p>
</td>
<td width="240">
<p>23</p>
</td>
<td width="156">
<p>27</p>
</td>
<td width="251">
<p>M</p>
</td>
</tr>
<tr>
<td width="184">
<p>27</p>
</td>
<td width="103">
<p>4.16</p>
</td>
<td width="456">
<p>Meh..</p>
</td>
<td width="240">
<p>20</p>
</td>
<td width="156">
<p>57</p>
</td>
<td width="251">
<p>F</p>
</td>
</tr>
</tbody>
</table>
<h2>10.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Customers without Feedback</h2>
<p>Select all customers <strong>without</strong> feedbacks. Order them by customer id (ascending).</p>
<p>Required columns:</p>
<ul>
<li>CustomerName &ndash; customer&rsquo;s first and last name, concatenated with space</li>
<li>PhoneNumber</li>
<li>Gender</li>
</ul>
<p>Example:</p>
<table>
<tbody>
<tr>
<td width="219">
<p><strong>CustomerName</strong></p>
</td>
<td width="223">
<p><strong>PhoneNumber</strong></p>
</td>
<td width="223">
<p><strong>Gender</strong></p>
</td>
</tr>
<tr>
<td width="219">
<p>Rachel Bishop</p>
</td>
<td width="223">
<p>0779574407</p>
</td>
<td width="223">
<p>F</p>
</td>
</tr>
<tr>
<td width="219">
<p>Irene Peters</p>
</td>
<td width="223">
<p>0995086966</p>
</td>
<td width="223">
<p>F</p>
</td>
</tr>
</tbody>
</table>
<h2>11.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Honorable Mentions</h2>
<p>Select <strong>all</strong> feedbacks given by <strong>customers</strong> which have at least <strong>3</strong> <strong>feedbacks</strong>. Order them by product Id then by customer name and lastly by feedback id &ndash; all ascending.</p>
<p>Required columns:</p>
<ul>
<li>ProductId</li>
<li>CustomerName &ndash; customer&rsquo;s first and last name, concatenated with space</li>
<li>FeedbackDescription</li>
</ul>
<p>Example:</p>
<table>
<tbody>
<tr>
<td width="185">
<p><strong>ProductId</strong></p>
</td>
<td width="341">
<p><strong>CustomerName</strong></p>
</td>
<td width="686">
<p><strong>FeedbackDescription</strong></p>
</td>
</tr>
<tr>
<td width="185">
<p>3</p>
</td>
<td width="341">
<p>Lisa Green</p>
</td>
<td width="686">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="185">
<p>6</p>
</td>
<td width="341">
<p>Lisa Green</p>
</td>
<td width="686">
<p>First food was not ok. Second I do not like sombreros. Third the music was bad.</p>
</td>
</tr>
</tbody>
</table>
<h2>12.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Customers by Criteria</h2>
<p>Select customers that are <strong>either</strong> at least 21 old <strong>and</strong> contain &ldquo;<strong>an</strong>&rdquo; in their first name <strong>or</strong> their phone number ends with &ldquo;38&rdquo; <strong>and</strong> are <strong>not</strong> from Greece. Order by first name (ascending), then by age(descending).</p>
<p>Required columns:</p>
<ul>
<li>FirstName</li>
<li>Age</li>
<li>PhoneNumber</li>
</ul>
<p>Example:</p>
<table>
<tbody>
<tr>
<td width="185">
<p><strong>FirstName</strong></p>
</td>
<td width="223">
<p><strong>Age</strong></p>
</td>
<td width="223">
<p><strong>PhoneNumber</strong></p>
</td>
</tr>
<tr>
<td width="185">
<p>Amanda</p>
</td>
<td width="223">
<p>30</p>
</td>
<td width="223">
<p>0886609909</p>
</td>
</tr>
<tr>
<td width="185">
<p>Antonio</p>
</td>
<td width="223">
<p>49</p>
</td>
<td width="223">
<p>0781375797</p>
</td>
</tr>
<tr>
<td width="185">
<p>Edward</p>
</td>
<td width="223">
<p>55</p>
</td>
<td width="223">
<p>0988359338</p>
</td>
</tr>
</tbody>
</table>
<h2>13.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Middle Range Distributors</h2>
<p>Select all distributors which distribute <strong>ingredients</strong> used in the making process of all products having average rate between <strong>5</strong> and<strong> 8 </strong>(inclusive). Order by distributor name, ingredient name and product name all ascending.</p>
<p>Required columns:</p>
<ul>
<li>DistributorName</li>
<li>IngredientName</li>
<li>ProductName</li>
<li>AverageRate</li>
</ul>
<p>Example:</p>
<table>
<tbody>
<tr>
<td width="234">
<p><strong>DistributorName</strong></p>
</td>
<td width="228">
<p><strong>IngredientName</strong></p>
</td>
<td width="252">
<p><strong>ProductName</strong></p>
</td>
<td width="223">
<p><strong>AverageRate</strong></p>
</td>
</tr>
<tr>
<td width="234">
<p>Alprazolam</p>
</td>
<td width="228">
<p>Cinnamon</p>
</td>
<td width="252">
<p>Nicotine Pleasure</p>
</td>
<td width="223">
<p>5.260000</p>
</td>
</tr>
<tr>
<td width="234">
<p>Arinase</p>
</td>
<td width="228">
<p>Peppercorn</p>
</td>
<td width="252">
<p>Panetone</p>
</td>
<td width="223">
<p>5.400000</p>
</td>
</tr>
<tr>
<td width="234">
<p>&hellip;</p>
</td>
<td width="228">
<p>&hellip;</p>
</td>
<td width="252">
<p>&hellip;</p>
</td>
<td width="223">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>14.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; The Most Positive Country</h2>
<p>Select the country which gave the most positive feedbacks. If there are several &ndash; print them all. Required columns:</p>
<ul>
<li>CountryName</li>
<li>FeedbackRate &ndash; average feedback rate for each country</li>
</ul>
<p>Example:</p>
<table width="848">
<tbody>
<tr>
<td width="453">
<p><strong>CountryName</strong></p>
</td>
<td width="395">
<p><strong>FeedbackRate</strong></p>
</td>
</tr>
<tr>
<td width="453">
<p>Serbia</p>
</td>
<td width="395">
<p>9.570000</p>
</td>
</tr>
</tbody>
</table>
<h2>15.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Country Representative</h2>
<p>Select all countries with their most active distributor (the one with the greatest number of ingredients). If there are several distributors with most ingredients delivered, list them all. Order by country name then by distributor name.</p>
<p>Required columns:</p>
<ul>
<li>CountryName</li>
<li>DistributorName</li>
</ul>
<p>Example:</p>
<table width="944">
<tbody>
<tr>
<td width="453">
<p><strong>CountryName</strong></p>
</td>
<td width="491">
<p><strong>DisributorName</strong></p>
</td>
</tr>
<tr>
<td width="453">
<p>Albania</p>
</td>
<td width="491">
<p>Arinase</p>
</td>
</tr>
<tr>
<td width="453">
<p>Andorra</p>
</td>
<td width="491">
<p>Allopurinol</p>
</td>
</tr>
<tr>
<td width="453">
<p>Andorra</p>
</td>
<td width="491">
<p>SPF 17</p>
</td>
</tr>
<tr>
<td width="453">
<p>&hellip;</p>
</td>
<td width="491">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h1>Section 4. Programmability (20 pts)</h1>
<p><strong><u>For this section put your queries in judge and use: &ldquo;<em>SQL Server run skeleton, run queries and check DB</em>&rdquo;.</u></strong></p>
<h2>16.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Customers with Countries</h2>
<p>Create a view named <strong>v_UserWithCountries</strong> which selects all <strong>customers</strong> with <strong>their</strong> <strong>countries</strong>.</p>
<p>Required columns:</p>
<ul>
<li>CustomerName &ndash; first name plus last name, with space between them</li>
<li>Age</li>
<li>Gender</li>
<li>CountryName</li>
</ul>
<p>Example usage:</p>
<table width="1391">
<tbody>
<tr>
<td colspan="4" width="1391">
<p><strong>Query</strong></p>
</td>
</tr>
<tr>
<td colspan="4" width="1391">
<p>SELECT TOP 5 *</p>
<p>&nbsp; FROM v_UserWithCountries</p>
<p>&nbsp;ORDER BY Age</p>
</td>
</tr>
<tr>
<td width="448">
<p>CustomerName</p>
</td>
<td width="214">
<p>Age</p>
</td>
<td width="281">
<p>Gender</p>
</td>
<td width="448">
<p>CountryName</p>
</td>
</tr>
<tr>
<td width="448">
<p>Paul Wells</p>
</td>
<td width="214">
<p>6</p>
</td>
<td width="281">
<p>M</p>
</td>
<td width="448">
<p>Philippines</p>
</td>
</tr>
<tr>
<td width="448">
<p>Jeremy Banks</p>
</td>
<td width="214">
<p>7</p>
</td>
<td width="281">
<p>M</p>
</td>
<td width="448">
<p>Brazil</p>
</td>
</tr>
<tr>
<td width="448">
<p>Marie Hudson</p>
</td>
<td width="214">
<p>7</p>
</td>
<td width="281">
<p>F</p>
</td>
<td width="448">
<p>Bulgaria</p>
</td>
</tr>
<tr>
<td width="448">
<p>&hellip;</p>
</td>
<td width="214">
<p>&hellip;</p>
</td>
<td width="281">
<p>&hellip;</p>
</td>
<td width="448">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>17.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Feedback by Product Name</h2>
<p>Create a <strong>user defined function</strong> that receives a product&rsquo;s name and returns its rating as a word, based on its average Rate. For rates lower than 5, return "<strong>Bad</strong>", for rates between 5 and 8 return "<strong>Average</strong>" and for rates above 8, return "<strong>Good</strong>". If a product has no feedback, return "<strong>No rating</strong>".</p>
<p>Parameters:</p>
<ul>
<li>ProductName</li>
</ul>
<p>Example usage:</p>
<table width="1391">
<tbody>
<tr>
<td colspan="3" width="1391">
<p><strong>Query</strong></p>
</td>
</tr>
<tr>
<td colspan="3" width="1391">
<p>SELECT TOP 5 Id, Name, dbo.udf_GetRating(Name)</p>
<p>&nbsp; FROM Products</p>
<p>&nbsp;ORDER BY Id</p>
</td>
</tr>
<tr>
<td width="132">
<p>Id</p>
</td>
<td width="531">
<p>Name</p>
</td>
<td width="729">
<p>(No column name)</p>
</td>
</tr>
<tr>
<td width="132">
<p>1</p>
</td>
<td width="531">
<p>Octinoxate</p>
</td>
<td width="729">
<p>Good</p>
</td>
</tr>
<tr>
<td width="132">
<p>2</p>
</td>
<td width="531">
<p>Tobacco Cake</p>
</td>
<td width="729">
<p>No rating</p>
</td>
</tr>
<tr>
<td width="132">
<p>3</p>
</td>
<td width="531">
<p>Musaka</p>
</td>
<td width="729">
<p>Good</p>
</td>
</tr>
<tr>
<td width="132">
<p>&hellip;</p>
</td>
<td width="531">
<p>&hellip;</p>
</td>
<td width="729">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>18.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Send Feedback</h2>
<p>Each <strong>Customer</strong> should not have more than <strong>3 feedbacks</strong> per <strong>product</strong>. Your task is to create a user defined procedure (<strong>usp_SendFeedback</strong>) which accepts customer&rsquo;s id, product&rsquo;s id, rate and description.&nbsp; You should insert the data <strong>but</strong> if the user already has 3 feedbacks &ndash; <strong>rollback</strong> any changes and throw an <strong>exception</strong> with message &ldquo;<strong>You are limited to only 3 feedbacks per product!</strong>&rdquo; with Severity = <strong>16</strong> and State = <strong>1</strong>.</p>
<p>Parameters:</p>
<ul>
<li>CustomerId</li>
<li>ProductId</li>
<li>Rate</li>
<li>Description</li>
</ul>
<p>Example usage:</p>
<table width="1391">
<tbody>
<tr>
<td width="1391">
<p><strong>Query</strong></p>
</td>
</tr>
<tr>
<td width="1391">
<p>EXEC usp_SendFeedback 1, 5, 7.50, 'Average experience';</p>
<p>SELECT COUNT(*) FROM Feedbacks WHERE CustomerId = 1 AND ProductId = 5;</p>
</td>
</tr>
<tr>
<td width="1391">
<p>Response</p>
</td>
</tr>
<tr>
<td width="1391">
<p>1</p>
</td>
</tr>
</tbody>
</table>
<h2>19.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Delete Products</h2>
<p>Create a trigger that deletes all of the relations of a product upon its deletion.</p>
<p>Example usage:</p>
<table width="1391">
<tbody>
<tr>
<td width="1391">
<p><strong>Query</strong></p>
</td>
</tr>
<tr>
<td width="1391">
<p>DELETE FROM Products WHERE Id = 7</p>
</td>
</tr>
<tr>
<td width="1391">
<p>Response</p>
</td>
</tr>
<tr>
<td width="1391">
<p>(1 row(s) affected)</p>
<p>&nbsp;</p>
<p>(3 row(s) affected)</p>
<p>&nbsp;</p>
<p>(1 row(s) affected)</p>
<p>&nbsp;</p>
<p>(1 row(s) affected)</p>
</td>
</tr>
</tbody>
</table>
<h1>Section 5. Bonus (10 pts)</h1>
<p><strong><u>For this section put your queries in judge and use: &ldquo;<em>SQL Server prepare DB and run queries</em>&rdquo;.</u></strong></p>
<h2>20.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Products by One Distributor</h2>
<p>Select all products which ingredients are delivered by only one distributor. Order them by product Id.</p>
<p>Required columns:</p>
<ul>
<li>ProductName</li>
<li>ProductAverageRate</li>
<li>DistributorName</li>
<li>DistributorCountry</li>
</ul>
<p>Example:</p>
<table width="1390">
<tbody>
<tr>
<td width="283">
<p><strong>ProductName</strong></p>
</td>
<td width="316">
<p><strong>ProductAverageRate</strong></p>
</td>
<td width="393">
<p><strong>DistributorName</strong></p>
</td>
<td width="398">
<p><strong>DistributorCountry</strong></p>
</td>
</tr>
<tr>
<td width="283">
<p>Octinoxate</p>
</td>
<td width="316">
<p>9.650000</p>
</td>
<td width="393">
<p>Lovastatin</p>
</td>
<td width="398">
<p>Brazil</p>
</td>
</tr>
<tr>
<td width="283">
<p>Salad</p>
</td>
<td width="316">
<p>6.475000</p>
</td>
<td width="393">
<p>Frova</p>
</td>
<td width="398">
<p>South Korea</p>
</td>
</tr>
<tr>
<td width="283">
<p>Banitsa</p>
</td>
<td width="316">
<p>5.540000</p>
</td>
<td width="393">
<p>Rabbitbush</p>
</td>
<td width="398">
<p>Serbia</p>
</td>
</tr>
<tr>
<td width="283">
<p>&hellip;</p>
</td>
<td width="316">
<p>&hellip;</p>
</td>
<td width="393">
<p>&hellip;</p>
</td>
<td width="398">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>