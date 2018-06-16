<h1>JS Apps Exam &ndash; Point Of Sale Single Page Application</h1>
<p>You are assigned to implement a <strong>Web application</strong> (SPA) using HTML5, JavaScript, AJAX, REST and JSON with cloud-based backend (Kinvey). The <strong>app </strong>that keeps <strong>users</strong> (cashiers), <strong>product entires</strong> and <strong>receipts</strong>. Users can <strong>register</strong>, <strong>login</strong>, <strong>logout</strong>, access the <strong>main view</strong> where a <strong>receipt</strong> can be <strong>composed</strong> (add products with their <strong>qunatity</strong> and <strong>price</strong> and save the basket to the database), list of all <strong>receipts </strong>and a <strong>receipt details</strong> view.</p>
<p>You are <strong>allowed</strong> to use libraries like <strong>jQuery</strong>, <strong>Handlebars</strong> and <strong>Sammy</strong>. <strong><em>Frameworks and libraries like React, Angular, Vue are not permitted!</em></strong></p>
<h2>Problem 1.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Create a Kinvey REST Service</h2>
<p>Register at <strong>Kinvey.com</strong> and create an application to keep your data in the cloud.</p>
<p>Create a collection <strong>entries</strong>. Each product has <strong>type</strong>, <strong>qty</strong>, <strong>price</strong> and <strong>receiptId</strong>.</p>
<p>Create a collection <strong>receipts</strong>. Each receipt has an <strong>active</strong> property, initially set to <strong>true</strong>, <strong>productCount</strong> and <strong>total</strong>.</p>
<h2>Problem 2.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Test the Kinvey REST Services</h2>
<h3>Common Responses</h3>
<p><strong>Note:</strong> When creating or updating records, the response will contain the <strong>entire record</strong> body, as it appears in the database. It&rsquo;s advisable if you observe network traffic via Postman or using your browser&rsquo;s dev-tools, to view details about each request.</p>
<table>
<tbody>
<tr>
<td width="261">
<p><strong>Response Code</strong></p>
</td>
<td width="1141">
<p><strong>Response Body</strong></p>
</td>
</tr>
<tr>
<td width="261">
<p>200 OK</p>
</td>
<td width="1141">
<p><em>&lt;Record data&gt;</em></p>
</td>
</tr>
<tr>
<td width="261">
<p>201 Created</p>
</td>
<td width="1141">
<p><em>&lt;Record data&gt;</em></p>
</td>
</tr>
<tr>
<td width="261">
<p>204 No Content</p>
</td>
<td width="1141">
<p><em>&lt;Empty&gt;</em></p>
</td>
</tr>
<tr>
<td width="261">
<p>401 Unauthorized</p>
</td>
<td width="1141">
<p>{</p>
<p>&nbsp; "error": "InvalidCredentials",</p>
<p>&nbsp; "description": "Invalid credentials. &hellip;",</p>
<p>&nbsp; "debug": ""</p>
<p>}</p>
</td>
</tr>
<tr>
<td width="261">
<p>404 Not Found</p>
</td>
<td width="1141">
<p>{</p>
<p>&nbsp; "error": "EntityNotFound",</p>
<p>&nbsp; "description": "This entity not found in the collection",</p>
<p>&nbsp; "debug": ""</p>
<p>}</p>
</td>
</tr>
<tr>
<td width="261">
<p>Error response</p>
<p>409 Conflict</p>
</td>
<td width="1141">
<p>{</p>
<p>&nbsp; "error": "UserAlreadyExists",</p>
<p>&nbsp; "description": "This username is already taken. &hellip;",</p>
<p>&nbsp; "debug": ""</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>Using <strong>Postman</strong> or other HTTP client tool (you can use Kinvey&rsquo;s built-in <strong>API Console</strong>), test the REST service endpoints:</p>
<h3>User Registration (Sign Up)</h3>
<table>
<tbody>
<tr>
<td colspan="2" width="1402">
<p><strong>POST</strong> https://baas.kinvey.com/user/<strong><em>app_key</em></strong>/</p>
</td>
</tr>
<tr>
<td width="261">
<p>Request headers</p>
</td>
<td width="1141">
<p>Authorization: Basic base64(app_id:app_secret)</p>
<p>Content-Type: application/json</p>
</td>
</tr>
<tr>
<td width="261">
<p>Request body</p>
</td>
<td width="1141">
<p>{</p>
<p>&nbsp; "username": "testuser",</p>
<p>&nbsp; "password": "testuserpass890"</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<p>The request needs &ldquo;<strong>Basic</strong>&rdquo; authentication. Use the Kinvey <strong>App Key</strong> and Kinvey <strong>App Secret</strong> as credentials.</p>
<h3>User Login</h3>
<table>
<tbody>
<tr>
<td colspan="2" width="1402">
<p><strong>POST</strong> https://baas.kinvey.com/user/<strong><em>app_key</em></strong>/login</p>
</td>
</tr>
<tr>
<td width="261">
<p>Request headers</p>
</td>
<td width="1141">
<p>Authorization: Basic base64(app_id:app_secret)</p>
<p>Content-Type: application/json</p>
</td>
</tr>
<tr>
<td width="261">
<p>Request body</p>
</td>
<td width="1141">
<p>{</p>
<p>&nbsp; "username": "testuser",</p>
<p>&nbsp; "password": "testuserpass890"</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<p>Successful login returns an &ldquo;<strong>authtoken</strong>&rdquo; which is later used to authenticate the CRUD operations.</p>
<h3>User Logout</h3>
<table>
<tbody>
<tr>
<td colspan="2" width="1402">
<p><strong>POST</strong> https://baas.kinvey.com/user/<strong><em>app_key</em></strong>/_logout</p>
</td>
</tr>
<tr>
<td width="261">
<p>Request headers</p>
</td>
<td width="1141">
<p>Authorization: Kinvey <strong>authtoken</strong></p>
</td>
</tr>
</tbody>
</table>
<p>To logout, you need to provide the &ldquo;<strong>authtoken</strong>&rdquo; given by login / register as &ldquo;<strong>Kinvey</strong>&rdquo; authorization header.</p>
<h3>Get Active Receipt</h3>
<table>
<tbody>
<tr>
<td colspan="2" width="1395">
<p><strong>GET </strong>https://baas.kinvey.com/appdata/<strong>app_key</strong>/receipts?query={"_acl.creator":"<strong>userId</strong>","active":"<strong>true</strong>"}</p>
</td>
</tr>
<tr>
<td width="261">
<p>Request headers</p>
</td>
<td width="1134">
<p>Authorization: Kinvey authtoken</p>
</td>
</tr>
</tbody>
</table>
<p>This will return the receipt that&rsquo;s <strong>active</strong> for the currently <strong>logged in user</strong>. Use this to populate the <strong>Editor</strong>, or if it&rsquo;s not found &ndash; create a new receipt and set it to be active.</p>
<h3>Get Entries by Receipt ID</h3>
<table>
<tbody>
<tr>
<td colspan="2" width="1402">
<p><strong>GET</strong> https://baas.kinvey.com/appdata/<strong>app_key</strong>/entries?query={"receiptId":"<strong>receiptId</strong>"}</p>
</td>
</tr>
<tr>
<td width="261">
<p>Request headers</p>
</td>
<td width="1141">
<p>Authorization: Kinvey authtoken</p>
</td>
</tr>
</tbody>
</table>
<p>You may use this query to get all entries of the currently <strong>active receipt</strong>, or entries for <strong>receipt details</strong>.</p>
<h3>Create Receipt</h3>
<table>
<tbody>
<tr>
<td colspan="2" width="1402">
<p><strong>POST</strong> https://baas.kinvey.com/appdata/<strong><em>app_key</em></strong>/receipts</p>
</td>
</tr>
<tr>
<td width="261">
<p>Request headers</p>
</td>
<td width="1141">
<p>Authorization: Kinvey authtoken</p>
<p>Content-Type: application/json</p>
</td>
</tr>
<tr>
<td width="261">
<p>Request body</p>
</td>
<td width="1141">
<p>{</p>
<p>&nbsp; "active": true,</p>
<p>&nbsp; "productCount": 0,</p>
<p>&nbsp; "total": 0</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<h3>Add Entry</h3>
<table>
<tbody>
<tr>
<td colspan="2" width="1402">
<p><strong>POST</strong> https://baas.kinvey.com/appdata/<strong><em>app_key</em></strong>/entries</p>
</td>
</tr>
<tr>
<td width="261">
<p>Request headers</p>
</td>
<td width="1141">
<p>Authorization: Kinvey authtoken</p>
<p>Content-Type: application/json</p>
</td>
</tr>
<tr>
<td width="261">
<p>Request body</p>
</td>
<td width="1141">
<p>{</p>
<p>&nbsp; "type": "Apple",</p>
<p>&nbsp; "qty": 5,</p>
<p>&nbsp; "price": 0.3,</p>
<p>&nbsp; "receiptId": "59affdae3044bb86044a79bd"</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<p>New entries should always be added to the <strong>active receipt</strong>.</p>
<h3>Delete Entry</h3>
<table>
<tbody>
<tr>
<td colspan="2" width="1402">
<p><strong>DELETE</strong> https://baas.kinvey.com/appdata/<strong><em>app_key</em></strong>/entries/<strong><em>entry_id </em></strong></p>
</td>
</tr>
<tr>
<td width="261">
<p>Request headers</p>
</td>
<td width="1141">
<p>Authorization: Kinvey authtoken</p>
</td>
</tr>
</tbody>
</table>
<h3>Get My Receipts</h3>
<table width="1391">
<tbody>
<tr>
<td colspan="2" width="1391">
<p><strong>GET </strong>https://baas.kinvey.com/appdata/<strong>app_key</strong>/receipts?query={"_acl.creator":"<strong>userId</strong>","active":"<strong>false</strong>"}</p>
</td>
</tr>
<tr>
<td width="266">
<p>Request headers</p>
</td>
<td width="1125">
<p>Authorization: Kinvey authtoken</p>
</td>
</tr>
</tbody>
</table>
<p>Use the ID of the currently <strong>logged in user</strong>. <strong><em>The user should see only his or her receipts on the overview screen.</em></strong></p>
<h3>Receipt Details</h3>
<table>
<tbody>
<tr>
<td colspan="2" width="1402">
<p><strong>GET</strong> https://baas.kinvey.com/appdata/<strong>app_key</strong>/receipts/<strong>receipt_id</strong></p>
</td>
</tr>
<tr>
<td width="261">
<p>Request headers</p>
</td>
<td width="1141">
<p>Authorization: Kinvey authtoken</p>
</td>
</tr>
</tbody>
</table>
<h3>Commit Receipt</h3>
<table>
<tbody>
<tr>
<td colspan="2" width="1402">
<p><strong>PUT</strong>&nbsp; https://baas.kinvey.com/appdata/<strong>app_key</strong>/receipts/<strong>receipt_id</strong></p>
</td>
</tr>
<tr>
<td width="261">
<p>Request headers</p>
</td>
<td width="1141">
<p>Authorization: Kinvey authtoken</p>
<p>Content-Type: application/json</p>
</td>
</tr>
<tr>
<td width="261">
<p>Request body</p>
</td>
<td width="1141">
<p>{</p>
<p>&nbsp; "active": false,</p>
<p>&nbsp; "productCount": 0,&nbsp;&nbsp;&nbsp; <em>// Sum of all products</em></p>
<p>&nbsp; "total": 0,&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <em>// Total cost of all products</em></p>
<p>&nbsp; <em>// Other receipt properties</em></p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<p>To mark a receipt as finalized (client has checked out), simply update it to set its <strong>active</strong> property to <strong>false</strong>. You need to send the whole receipt object, so don&rsquo;t forget to fetch the receipt from the database first.</p>
<h2>Problem 3.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; HTML and CSS</h2>
<p>You аre given the Web design of the application as <strong>HTML</strong> + <strong>CSS</strong> files.</p>
<ul>
<li>Initially all views and forms are shown by the HTML. Your application may <strong>hide</strong> by CSS (display: none) or <strong>delete</strong> from the DOM all unneeded elements or just display the views it needs to display.</li>
<li>You may render the views / forms / components with <strong>jQuery</strong> or <strong>Handlebars</strong>.</li>
</ul>
<p><strong>Important</strong>: don&rsquo;t change the elements&rsquo; <strong>class name</strong> and <strong>id</strong>. Don&rsquo;t rename form fields / link names / ids. You are <strong>allowed</strong> to add <strong>data attributes</strong> to any elements. You may modify <strong>href</strong><strong> attributes</strong> of links and add <strong>action/method attributes</strong> to forms, to allow the use of a routing library.</p>
<p><strong><em>Including the &lt;section&gt; elements is required for the style to display correctly!</em></strong></p>
<h2>Problem 4.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Client-Side Web Application</h2>
<p><strong>Design</strong> and <strong>implement</strong> a client-side front-end app (SPA). Implement the functionality described below.</p>
<h3>Notifications (10 pts)</h3>
<p>The application should notify the users about the result of their actions.</p>
<ul>
<li>In case of successful action an <strong>informational (green) notification message</strong> should be shown, which disappears automatically after 3 seconds or manually when the user clicks it.</li>
<li>In case of <strong>error</strong>, an <strong>error notification </strong><strong>message (red) </strong>should be shown which disappears on user click.</li>
<li>During the AJAX calls a <strong>loading notification message (blue)</strong> should be shown. It should disappear automatically as soon as the AJAX call is completed.</li>
</ul>
<p><strong><em>Points for notifications are awarded separately for each section.</em></strong></p>
<h3>Navigation System (10 pts)</h3>
<p>Implement a <strong>navigation system</strong> for the app: navigation links should correctly change the current screen (view).</p>
<ul>
<li>Clicking on the links in the <strong>menu</strong> or <strong>individual</strong> links should display the view behind the link (views are sections in the HTML code).</li>
<li>The given &bdquo;<strong>Navigation</strong>&ldquo; menu should be visible <strong>only</strong> for logged in users. Anonymous users can <strong>only</strong> view the <strong>sign in/register</strong></li>
</ul>
<h3>Register User Screen (5 pts)</h3>
<p>By given <strong>username</strong>, <strong>password</strong><strong> and repeat password</strong> the app should register a new user in the system.</p>
<ul>
<li>After a <strong>successful registration</strong>, a notification message &ldquo;User registration successful.&rdquo; should be displayed and the user should be <strong>redirected</strong> to the home view.</li>
<li>You <strong>need</strong> to validate the <strong>input</strong>. A username <strong>should</strong> be a string with at <strong>least</strong> 5 characters<strong> long</strong>. Passwords <strong>input</strong> fields shouldn&rsquo;t be <strong>empty</strong>. Both passwords <strong>should</strong></li>
<li>In case of <strong>error</strong> (eg. invalid username/password), an appropriate error <strong>message</strong> should be displayed and the user should be able to <strong>try</strong> to register again.</li>
<li>Keep the user session data in the browser&rsquo;s <strong>session storage</strong>.</li>
<li>Clear <strong>all</strong> input fields after <strong>successful</strong> register.</li>
</ul>
<h3>Login User Screen (5 pts)</h3>
<p>By given <strong>username</strong> and <strong>password</strong> the app should be able to login an existing user.</p>
<ul>
<li>After a <strong>successful login</strong>, a notification message &ldquo;Login successful.&rdquo; should be displayed and and the user should be <strong>redirected</strong> to the home view.</li>
<li>In case of <strong>error</strong>, an appropriate error message should be displayed and the user should be able to fill the login form again.</li>
<li><strong>Form validation</strong> should be the <strong>same</strong> as register.</li>
<li>Keep the user session data in the browser&rsquo;s <strong>session storage</strong>.</li>
<li>Clear <strong>all</strong> input fields after <strong>successful</strong></li>
</ul>
<h3>Logout (5 pts)</h3>
<p>Successfully logged in user should be able to <strong>logout</strong> from the app.</p>
<ul>
<li>After a <strong>successful</strong> logout, a <strong>notification</strong> message &ldquo;Logout successful.&rdquo; should be displayed.</li>
<li>After successful logout, the <strong>Sign </strong><strong>In screen</strong> should be shown.</li>
<li>The <strong>&ldquo;logout&rdquo; REST service</strong> at the back-end should be obligatory called at logout.</li>
<li>All local information in the browser (<strong>user session data</strong>) about the current user should be deleted.</li>
</ul>
<h3>Home Screen (Receipt Editor) (45 pts)</h3>
<h5>Display Currently Active Receipt (15 pts)</h5>
<p>Whenever the user opens the editor, you should retrieve the currently <strong>active receipt</strong> and all products related to it (by <strong>receiptId</strong>). If there is no active receipt, you must create it in the database. Note that the HTML contains <strong>hidden input fields</strong>, which you can use. <strong><em>There must be only one active receipt at any one time on the server!</em></strong></p>
<h5>Add New Entry (10pts)</h5>
<p>Clicking on Add creates a new entry, using the receipt ID of the currently active receipt and the data from the input fields. The fields must be validated:</p>
<ul>
<li>Product <strong>name</strong> must be a <strong>non-empty string</strong></li>
<li><strong>Quantity</strong> must be a <strong>number</strong></li>
<li><strong>Price</strong> must be a <strong>number</strong></li>
</ul>
<p>Update the value of <strong>Sub-total</strong> and <strong>Total</strong> in real time, whenever the user changes Quantity or Price to a valid value. Upon successfully adding the entry to the database</p>
<p>After successful entry creation, display a notification &ldquo;Entry added&rdquo;, <strong>add the information </strong>to the end of the list of entries and <strong>clear all input values</strong>.</p>
<h5>Update Sub-total and Total (5 pts)</h5>
<p>When the user enters a <strong>valid value</strong> for <strong>Quantity</strong> and <strong>Price per Unit</strong>, the displayed values for <strong>Sub-total</strong> for the new entry and <strong>Total</strong> for the receipt should be updated.</p>
<h5>Remove Entry (5 pts)</h5>
<p>Clicking the <strong>delete button</strong> next to each entry must <strong>remove it</strong> from the database and <strong>delete the row</strong> from the table. After successful deletion, <strong>update</strong> the value of Total. Display a notification &ldquo;Entry removed&rdquo; and <strong>remove the corresponding elements </strong>from the list of entries.</p>
<h5>Checkout Receipt (10 pts)</h5>
<p>Clicking on <strong>Checkout</strong> should perform the following:</p>
<ul>
<li>Display a <strong>notification</strong> &ldquo;Receipt checked out&rdquo;</li>
<li>Update the receipt in the database to have its <strong>active</strong> property set to <strong>false</strong> and the properties <strong>productCount</strong> and <strong>total</strong> populated with the correct values</li>
<li>Prepare the editor for a <strong>new receipt</strong> by creating it in the database and <strong>clearing the screen</strong> of any old information.</li>
</ul>
<p>Before carrying out any actions, make sure the receipt contains <strong>at least one entry</strong> &ndash; <strong><em>the user should not be able to checkout an empty receipt!</em></strong></p>
<h3>All Receipts (10 pts)</h3>
<p>Display a list of all receipts that the user has created. Use the stored user ID to retrieve only the relevant records. Every receipt must have a <strong>link</strong> that leads to its <strong>details</strong>. <strong><em>The user should see only his or her receipts.</em></strong></p>
<h3>Receipt Details (10 pts)</h3>
<p>Display the selected receipt with a list of all entries in it. Use the receipt ID to filter only the related entries.</p>
<h2>Problem 5.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Subtmitting Your Solution</h2>
<p>Place in a ZIP file your project folder. Exclude the node_modules folder. Upload the archive to the Judge.</p>