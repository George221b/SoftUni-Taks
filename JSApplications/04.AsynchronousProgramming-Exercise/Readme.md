<h1>Exercises: Asynchronous Programming and Promises</h1>
<p>Problems for exercises and homework for the <a href="https://softuni.bg/courses/javascript-applications">&ldquo;JavaScript Applications&rdquo; course @ SoftUni</a>. Submit your solutions in the SoftUni judge system at <a href="https://judge.softuni.bg/Contests/361/">https://judge.softuni.bg/Contests/361/</a>.</p>
<h2>1.&nbsp;&nbsp; Forecaster</h2>
<p>Write a JS program that requests a weather report from a server and displays it o the user. Use the following HTML to test your code:</p>
<table width="1361">
<tbody>
<tr>
<td width="1361">
<p>schedule.html</p>
</td>
</tr>
<tr>
<td width="1361">
<p>&lt;!DOCTYPE <strong>html</strong>&gt;<br /> &lt;<strong>html </strong><strong>lang=</strong><strong>"en"</strong>&gt;<br /> &lt;<strong>head</strong>&gt;<br /> &nbsp; &lt;<strong>meta </strong><strong>charset=</strong><strong>"UTF-8"</strong>&gt;<br /> &nbsp; &lt;<strong>title</strong>&gt;Forecatser&lt;/<strong>title</strong>&gt;<br /> &nbsp; &lt;<strong>style</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; <strong>#content </strong>{ <strong>width</strong>: 400<strong>px</strong>; }<br /> &nbsp;&nbsp;&nbsp; <strong>#request </strong>{ <strong>text-align</strong>: <strong>center</strong>; }<br /> &nbsp; &nbsp;&nbsp;.<strong>bl </strong>{ <strong>width</strong>: 300<strong>px</strong>; }<br /> &nbsp;&nbsp;&nbsp; <strong>#current </strong>{ <strong>text-align</strong>: <strong>center</strong>; <strong>font-size</strong>: 2<strong>em</strong>; }<br /> &nbsp;&nbsp;&nbsp; <strong>#upcoming </strong>{ <strong>text-align</strong>: <strong>center</strong>; }<br /> &nbsp; &nbsp;&nbsp;.<strong>condition </strong>{ <strong>text-align</strong>: <strong>left</strong>; <strong>display</strong>: <strong>inline-block</strong>; }<br /> &nbsp; &nbsp;&nbsp;.<strong>symbol </strong>{ <strong>font-size</strong>: 4<strong>em</strong>; <strong>display</strong>: <strong>inline-block</strong>; }<br /> &nbsp;&nbsp;&nbsp; .<strong>forecast-data </strong>{ <strong>display</strong>: <strong>block</strong>; }<br /> &nbsp; &nbsp;&nbsp;.<strong>upcoming </strong>{ <strong>display</strong>: <strong>inline-block</strong>; <strong>margin</strong>: 1.5<strong>em</strong>; }<br /> &nbsp;&nbsp; &nbsp;.<strong>label </strong>{ <strong>margin-top</strong>: 1<strong>em</strong>; <strong>font-size</strong>: 1.5<strong>em</strong>; <strong>background-color</strong>: <strong>aquamarine</strong>; <strong>font-weight</strong>: 400; }<br /> &nbsp; &lt;/<strong>style</strong>&gt;<br /> &nbsp; &lt;<strong>script </strong><strong>src=</strong><strong>"https://code.jquery.com/jquery-3.1.1.min.js"</strong>&gt;&lt;/<strong>script</strong>&gt;<br /> &lt;/<strong>head</strong>&gt;<br /> &lt;<strong>body</strong>&gt;<br /> &lt;<strong>div </strong><strong>id=</strong><strong>"content"</strong>&gt;<br /> &nbsp; &lt;<strong>div </strong><strong>id=</strong><strong>"request"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>input </strong><strong>id=</strong><strong>"location"</strong> <strong>class=</strong><strong>'bl' </strong><strong>type=</strong><strong>"text"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>input </strong><strong>id=</strong><strong>"submit"</strong> <strong>class=</strong><strong>"bl" </strong><strong>type=</strong><strong>"button" </strong><strong>value=</strong><strong>"Get Weather"</strong>&gt;<br /> &nbsp; &lt;/<strong>div</strong>&gt;<br /> &nbsp; &lt;<strong>div </strong><strong>id=</strong><strong>"forecast" </strong><strong>style=</strong><strong>"display:none"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>div </strong><strong>id=</strong><strong>"current"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>div </strong><strong>class=</strong><strong>"label"</strong>&gt;Current conditions&lt;/<strong>div</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;/<strong>div</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>div </strong><strong>id=</strong><strong>"upcoming"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>div </strong><strong>class=</strong><strong>"label"</strong>&gt;Three-day forecast&lt;/<strong>div</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;/<strong>div</strong>&gt;<br /> &nbsp; &lt;/<strong>div</strong>&gt;<br /> &lt;/<strong>div</strong>&gt;<br /> &lt;<strong>script </strong><strong>src=</strong><strong>"forecaster.js"</strong>&gt;&lt;/<strong>script</strong>&gt;<br /> &lt;<strong>script</strong>&gt;<br /> &nbsp;&nbsp;<em>attachEvents</em>();<br /> &lt;/<strong>script</strong>&gt;<br /> &lt;/<strong>body</strong>&gt;<br /> &lt;/<strong>html</strong>&gt;</p>
</td>
</tr>
</tbody>
</table>
<p>Submit only the attachEvents() function that attaches events to the <strong>button</strong> with ID "<strong>submit</strong>" and holds all program logic.</p>
<p>When the user writes the name of a location and clicks &ldquo;<strong>Get Weather</strong>&rdquo;, make a GET request to the server at address https://judgetests.firebaseio.com/locations.json. The response will be an array of objects, with structure:</p>
<p>{ name: locationName,</p>
<p>&nbsp; code: locationCode }</p>
<p>Find the object, corresponding to the name the user submitted in the input field with ID "<strong>location</strong>" and use its code value to make two more requests:</p>
<ul>
<li>For current conditions, make a GET request to https://judgetests.firebaseio.com/forecast/today/{code}.json (replace the highlighted part with the relevant value). The response from the server will be an object as follows:</li>
</ul>
<p>{ name: locationName,</p>
<p>&nbsp; forecast: { low: temp,</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; high: temp,</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; condition: condition } }</p>
<ul>
<li>For a 3-day forecast, make a GET request to https://judgetests.firebaseio.com/forecast/upcoming/{code}.json (replace the highlighted part with the relevant value). The response from the server will be an object as follows:</li>
</ul>
<p>{ name: locationName,</p>
<p>&nbsp; forecast: [{ low: temp,</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; high: temp,</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; condition: condition }, &hellip; ] }</p>
<p>Use the information from these two objects to compose a forecast in HTML and insert it inside the page. Note that the &lt;div&gt; with ID "<strong>forecast</strong>" must be set to <strong>visible</strong>. See the examples for details.</p>
<p>If an error occurs (the server doesn&rsquo;t respond or the location name cannot be found) or the data is not in the correct format, display "Error" in the forecast section.</p>
<p>Use the following codes for the weather sumbols:</p>
<ul>
<li>Sunny &amp;#x2600; // ☀</li>
<li>Partly sunny &amp;#x26C5; // ⛅</li>
<li>Overcast &amp;#x2601; // ☁</li>
<li>Rain &amp;#x2614; // ☂</li>
<li>Degrees &amp;#176; &nbsp;&nbsp;// &deg;</li>
</ul>
<h3>Examples</h3>
<p>When the app starts, the forecast div is hidden. When the user enters a name and clicks submit, the requests being.</p>
<h3>Hints</h3>
<p>The server at the address listed above will respond with valid data for location names "London", "New York" and "Barcelona".</p>
<h2>2.&nbsp;&nbsp; Fisher Game</h2>
<p>Create an application at <strong>kinvey.com</strong> Create a collection biggestCatches(angler, weight, species, location, bait, captureTime) to hold information about the largest fish caught.</p>
<ul>
<li>angler - string representing the name of the person who caught the fish</li>
<li>weight - floating point number representing the weight of the fish in kilograms</li>
<li>species - string representing the name of the fish species</li>
<li>location - string representing the location where the fish was caught</li>
<li>bait - string representing the bait used to catch the fish</li>
<li>captureTime - integer number representing the time needed to catch the fish in minutes</li>
</ul>
<h3>HTML Template</h3>
<p>You are given an HTML template to test your code, your task is to attach handlers to the [Load], [Update], [Delete] and [Add] buttons, which make the appropriate GET, PUT, DELETE and POST requests respectively.</p>
<table width="1361">
<tbody>
<tr>
<td width="1361">
<p>catch.html</p>
</td>
</tr>
<tr>
<td width="1361">&lt;!DOCTYPE <strong>html</strong>&gt;<br /> &lt;<strong>html </strong><strong>lang=</strong><strong>"en"</strong>&gt;<br /> &lt;<strong>head</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>meta </strong><strong>charset=</strong><strong>"UTF-8"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>title</strong>&gt;Biggest Catch&lt;/<strong>title</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>script </strong><strong>src=</strong><strong>"https://code.jquery.com/jquery-3.1.1.min.js"</strong>&gt;&lt;/<strong>script</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>script </strong><strong>src=</strong><strong>"catch.js"</strong>&gt;&lt;/<strong>script</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>style</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>h1 </strong>{ <strong>text-align</strong>: <strong>center</strong>; }<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>input </strong>{ <strong>display</strong>: <strong>block</strong>; }<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>div </strong>{ <strong>border</strong>: 1<strong>px solid black</strong>; <strong>padding</strong>: 5<strong>px</strong>; <strong>display</strong>: <strong>inline-table</strong>; <strong>width</strong>: 24%; }<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>div#aside </strong>{ <strong>margin-top</strong>: 8<strong>px</strong>; <strong>width</strong>: 15%; <strong>border</strong>: 2<strong>px solid grey</strong>; }<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>div#catches</strong>{ <strong>width</strong>:<strong>auto</strong>; }<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>button </strong>{ <strong>display</strong>: <strong>inline-table</strong>; <strong>margin</strong>: 5% 0 5% 5%; <strong>width</strong>: 39%; }<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>button</strong>.<strong>add </strong>{ <strong>width</strong>: 90%; }<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>button</strong>.<strong>load </strong>{ <strong>width</strong>: 90%; <strong>padding</strong>: 10<strong>px</strong>; }<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>button</strong>.<strong>load </strong>{ <strong>vertical-align</strong>: <strong>top</strong>; }<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>fieldset </strong>{ <strong>display</strong>: <strong>inline-table</strong>; <strong>vertical-align</strong>: <strong>top</strong>; }<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>fieldset#main </strong>{ <strong>width</strong>: 70%; }<br /> &nbsp;&nbsp;&nbsp; &lt;/<strong>style</strong>&gt;<br /> &lt;/<strong>head</strong>&gt;<br /> &lt;<strong>body</strong>&gt;<br /> &lt;<strong>h1</strong>&gt;Biggest Catches&lt;/<strong>h1</strong>&gt;<br /> &lt;<strong>fieldset </strong><strong>id=</strong><strong>"main"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>legend</strong>&gt;Catches&lt;/<strong>legend</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>div </strong><strong>id=</strong><strong>"catches"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>div </strong><strong>class=</strong><strong>"catch" </strong><strong>data-id=</strong><strong>"&lt;id-goes-here&gt;"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>label</strong>&gt;Angler&lt;/<strong>label</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>input </strong><strong>type=</strong><strong>"text" </strong><strong>class=</strong><strong>"angler" </strong><strong>value=</strong><strong>"Paulo Amorim"</strong>/&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>label</strong>&gt;Weight&lt;/<strong>label</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>input </strong><strong>type=</strong><strong>"number" </strong><strong>class=</strong><strong>"weight" </strong><strong>value=</strong><strong>"636"</strong>/&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>label</strong>&gt;Species&lt;/<strong>label</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>input </strong><strong>type=</strong><strong>"text" </strong><strong>class=</strong><strong>"species" </strong><strong>value=</strong><strong>"Atlantic Blue Marlin"</strong>/&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>label</strong>&gt;Location&lt;/<strong>label</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>input </strong><strong>type=</strong><strong>"text" </strong><strong>class=</strong><strong>"location" </strong><strong>value=</strong><strong>"Vit&oacute;ria, Brazil"</strong>/&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>label</strong>&gt;Bait&lt;/<strong>label</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>input </strong><strong>type=</strong><strong>"text" </strong><strong>class=</strong><strong>"bait" </strong><strong>value=</strong><strong>"trolled pink"</strong>/&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>label</strong>&gt;Capture Time&lt;/<strong>label</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>input </strong><strong>type=</strong><strong>"number" </strong><strong>class=</strong><strong>"captureTime" </strong><strong>value=</strong><strong>"80"</strong>/&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>button </strong><strong>class=</strong><strong>"update"</strong>&gt;Update&lt;/<strong>button</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>button </strong><strong>class=</strong><strong>"delete"</strong>&gt;Delete&lt;/<strong>button</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/<strong>div</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;/<strong>div</strong>&gt;<br /> &lt;/<strong>fieldset</strong>&gt;<br /> &lt;<strong>div </strong><strong>id=</strong><strong>"aside"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>button </strong><strong>class=</strong><strong>"load"</strong>&gt;Load&lt;/<strong>button</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>fieldset </strong><strong>id=</strong><strong>"addForm"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>legend</strong>&gt;Add Catch&lt;/<strong>legend</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>label</strong>&gt;Angler&lt;/<strong>label</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>input </strong><strong>type=</strong><strong>"text" </strong><strong>class=</strong><strong>"angler"</strong>/&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>label</strong>&gt;Weight&lt;/<strong>label</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>input </strong><strong>type=</strong><strong>"number" </strong><strong>class=</strong><strong>"weight"</strong>/&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>label</strong>&gt;Species&lt;/<strong>label</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>input </strong><strong>type=</strong><strong>"text" </strong><strong>class=</strong><strong>"species"</strong>/&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>label</strong>&gt;Location&lt;/<strong>label</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>input </strong><strong>type=</strong><strong>"text" </strong><strong>class=</strong><strong>"location"</strong>/&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>label</strong>&gt;Bait&lt;/<strong>label</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>input </strong><strong>type=</strong><strong>"text" </strong><strong>class=</strong><strong>"bait"</strong>/&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>label</strong>&gt;Capture Time&lt;/<strong>label</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>input </strong><strong>type=</strong><strong>"number" </strong><strong>class=</strong><strong>"captureTime"</strong>/&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>button </strong><strong>class=</strong><strong>"add"</strong>&gt;Add&lt;/<strong>button</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;/<strong>fieldset</strong>&gt;<br /> &lt;/<strong>div</strong>&gt;<br /> &lt;<strong>script</strong>&gt;<em>attachEvents</em>()&lt;/<strong>script</strong>&gt;<br /> &lt;/<strong>body</strong>&gt;<br /> &lt;/<strong>html</strong>&gt;</td>
</tr>
</tbody>
</table>
<p>You are given an example catch in the template to show you where and how you should insert the catches. Notice that the div containing the catch has an attribute data-id that should store the _id of the entry given by Kinvey.</p>
<p>Kinvey will automatically create the following REST services to access your data:</p>
<ul>
<li><strong>List All Catches</strong></li>
</ul>
<ul>
<li>Endpoint: <a href="https://baas.kinvey.com/appdata/%5b:appId%5d/biggestCatches">https://baas.kinvey.com/appdata/[:appId]/biggestCatches</a></li>
<li>Method: GET</li>
<li>Headers:</li>
</ul>
<ul>
<ul>
<ul>
<li>Basic Authorization with<strong> user credentials</strong></li>
</ul>
</ul>
</ul>
<ul>
<li>Returns (JSON)</li>
</ul>
<ul>
<li><strong>Create a New Catch</strong></li>
</ul>
<ul>
<li>Endpoint: <a href="https://baas.kinvey.com/appdata/%5b:appId%5d/biggestCatches">https://baas.kinvey.com/appdata/[:appId]/biggestCatches</a></li>
<li>Method: POST</li>
<li>Headers:</li>
</ul>
<ul>
<ul>
<ul>
<li>Basic Authorization with <strong>user credentials</strong></li>
<li>Content-type: application/json</li>
</ul>
</ul>
</ul>
<ul>
<li>Request body (JSON): {"angler":"&hellip;", "weight":&hellip;, "species":"&hellip;", "location":"&hellip;", "bait":"&hellip;", "captureTime":&hellip;}</li>
</ul>
<ul>
<li><strong>Update a Catch</strong></li>
</ul>
<ul>
<li>Endpoint: <a href="https://baas.kinvey.com/appdata/%5b:appId%5d/biggestCatches/%5b:catchId%5d">https://baas.kinvey.com/appdata/[:appId]/biggestCatches/[:catchId]</a></li>
<li>Method: PUT</li>
<li>Headers:</li>
</ul>
<ul>
<ul>
<ul>
<li>Basic Authorization with <strong>user credentials</strong></li>
<li>Content-type: application/json</li>
</ul>
</ul>
</ul>
<ul>
<li>Request body (JSON): {"angler":"&hellip;", "weight":&hellip;, "species":"&hellip;", "location":"&hellip;", "bait":"&hellip;", "captureTime":&hellip;}</li>
</ul>
<ul>
<li><strong>Delete a Catch</strong></li>
</ul>
<ul>
<li>Endpoint: <a href="https://baas.kinvey.com/appdata/%5b:appId%5d/biggestCatches/%5b:catchId%5d">https://baas.kinvey.com/appdata/[:appId]/biggestCatches/[:catchId]</a></li>
<li>Method: DELETE</li>
<li>Headers:</li>
</ul>
<ul>
<ul>
<ul>
<li>Basic Authorization with <strong>user credentials</strong></li>
<li>Content-type: application/json</li>
</ul>
</ul>
</ul>
<p>Pressing the [Load] button should list all catches, pressing a catch's [Update] button should send a PUT requests updating that catch in kinvey.com. Pressing a catch's [Delete] button should delete the catch both from kinvey and from the page. Pressing the [Add] button should submit a new catch with the values of the inputs in the Add fieldset.</p>
<h3>Screenshots</h3>
<h1>Extra tasks</h1>
<p>The following tasks don't have automated tests in the Judge system, they are for practicing.</p>
<h2>3.&nbsp;&nbsp; Create "Books" REST Service</h2>
<p>Register at <strong>kinvey.com</strong> and create an application. Create a class <strong>Book(title, author, isbn)</strong> to hold book objects. Fill a few sample books:</p>
<p>kinvey.com will automatically create the following REST services to access your data:</p>
<ul>
<li><strong>List All Books</strong></li>
</ul>
<ul>
<li>Endpoint: <a href="https://baas.kinvey.com/apdata/%5b:appId%5d/books">https://baas.kinvey.com/apdata/[:appId]/books</a></li>
<li>Method: GET</li>
<li>Headers:</li>
</ul>
<ul>
<ul>
<ul>
<li>Basic Authorization with<strong> user credentials</strong></li>
</ul>
</ul>
</ul>
<ul>
<li>Returns (JSON)</li>
</ul>
<ul>
<li><strong>Create a New Book</strong></li>
</ul>
<ul>
<li>Endpoint: <a href="https://baas.kinvey.com/apdata/%5b:appId%5d/books">https://baas.kinvey.com/apdata/[:appId]/books</a></li>
<li>Method: POST</li>
<li>Headers:</li>
</ul>
<ul>
<ul>
<ul>
<li>Basic Authorization with <strong>user credentials</strong></li>
<li>Content-type: application/json</li>
</ul>
</ul>
</ul>
<ul>
<li>Request body (JSON): {"title":"&hellip;", "author":"&hellip;", "isbn":"&hellip;"}</li>
</ul>
<ul>
<li><strong>Update a Book</strong></li>
</ul>
<ul>
<li>Endpoint: <a href="https://baas.kinvey.com/apdata/%5b:appId%5d/books/%5b:bookId%5d">https://baas.kinvey.com/apdata/[:appId]/books/[:bookId]</a></li>
<li>Method: PUT</li>
<li>Headers:</li>
</ul>
<ul>
<ul>
<ul>
<li>Basic Authorization with <strong>user credentials</strong></li>
<li>Content-type: application/json</li>
</ul>
</ul>
</ul>
<ul>
<li>Request body (JSON): {"title":"&hellip;", "author":"&hellip;", "isbn":"&hellip;"}</li>
</ul>
<ul>
<li><strong>Delete a Book</strong></li>
</ul>
<ul>
<li>Endpoint: <a href="https://baas.kinvey.com/apdata/%5b:appId%5d/books/%5b:bookId%5d">https://baas.kinvey.com/apdata/[:appId]/books/[:bookId]</a></li>
<li>Method: DELETE</li>
<li>Headers:</li>
</ul>
<ul>
<ul>
<ul>
<li>Basic Authorization with <strong>user credentials</strong></li>
<li>Content-type: application/json</li>
</ul>
</ul>
</ul>
<p>To view your kinvey.com access keys, go to your application dashboard &agrave; bottom-right menu &agrave; API keys:</p>
<p>Test your REST Service, e.g. using <strong>Postman</strong> Chrome Extension (<a href="http://www.getpostman.com">http://www.getpostman.com</a>). Try to list all books in JSON format with an HTTP GET request to the REST API of kinvey.com.</p>
<h2>List All Books</h2>
<p>Create a HTML5 project consisting of HTML, CSS and JS files. Add an AJAX call that takes all books from your application in kinvey.com as JSON object and displays them at page load.</p>
<h2>Create a Book</h2>
<p>Add a HTML form with submit button for adding a new book. When the button is pressed, create a new book at kinvey.com using its REST API with an AJAX request.</p>
<h2>Edit a Book</h2>
<p>Implement "Edit a Book" functionality. Clicking on a book should load its data in a HTML form. By clicking the submit button, the book data at kinvey.com should be updated at the server side with and AJAX request.</p>
<h2>Delete a Book</h2>
<p>Implement "Delete a Book" functionality. Each book should have "Delete" button. Clicking on it should delete the book at the server side with and AJAX request to the REST service.</p>
<h2>* Add Tags for Each Book</h2>
<p>Implement tags for the books. Tags should be stored at kinvey.com in the Book class in a column "<strong>tags</strong>" as arrays of strings. List the tags for each book. Implement add / edit / delete for tags when a book is created / updated.</p>
<h1>Practice</h1>
<p>The following tasks don't have automated tests in the Judge system, you are expected to check the problems yourself.</p>
<h2>4.&nbsp;&nbsp; Students</h2>
<p>Your task is to create functionality for creating and listing students from a database in Kinvey.</p>
<p>Here are the Kinvey application key and secret:</p>
<ul>
<li>APP KEY: kid_BJXTsSi-e</li>
<li>APP SECRET: 447b8e7046f048039d95610c1b039390</li>
</ul>
<p>Here is also a test user for you to log in with:</p>
<ul>
<li>Username: guest</li>
<li>Password: guest</li>
</ul>
<p>There is collection called students there, in the application.</p>
<p>The student entity has:</p>
<ul>
<li>ID &ndash; a number, <strong>non-empty</strong></li>
<li>FirstName &ndash; a String, <strong>non-empty</strong></li>
<li>LastName &ndash; a String, <strong>non-empty</strong></li>
<li>FacultyNumber &ndash; a String of <strong>numbers</strong>, <strong>non-empty</strong></li>
<li>Grade &ndash; a number, <strong>non-empty</strong></li>
</ul>
<p>You need to write functionality for creating students. When you are creating a new student, make sure you name these properties perfectly. Create at least one student to test your code.</p>
<p>You will also need to extract the students. You will be given an <strong>HTML template</strong> with a table in it. Create an AJAX request which extracts all the students. Upon fetching all the students from Kinvey, add them to the table each on a new row, <strong>sorted</strong> in <strong>ascending order</strong> by ID.</p>
<table width="1361">
<tbody>
<tr>
<td width="1361">
<p>students.html</p>
</td>
</tr>
<tr>
<td width="1361">
<p>&lt;!DOCTYPE <strong>html</strong>&gt;<br /> &lt;<strong>html </strong><strong>lang=</strong><strong>"en"</strong>&gt;<br /> &lt;<strong>head</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>meta </strong><strong>charset=</strong><strong>"UTF-8"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>title</strong>&gt;Shit&lt;/<strong>title</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>script </strong><strong>src=</strong><strong>"https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"</strong>&gt;&lt;/<strong>script</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>style</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>#results </strong>{<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>background-color</strong>: <strong>#FFFFFF</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>display</strong>: <strong>flex</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>flex-direction</strong>: <strong>column</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>text-align</strong>: <strong>center</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }<br /> <br /> &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<strong>#results tr </strong>{<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>background-color</strong>: <strong>#AAAAAA</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>padding</strong>: 5<strong>vh</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>font-size</strong>: 1.5<strong>vw</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }<br /> <br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>#results tr</strong>:<strong>nth-child</strong>(<strong>odd</strong>) {<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>background-color</strong>: <strong>#808080</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }<br /> <br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>#results tr</strong>:<strong>first-child </strong>{<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>background-color</strong>: <strong>#000000</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>color</strong>: <strong>#FFFFFF</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>font-weight</strong>: <strong>bold</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>font-size</strong>: 2<strong>vw</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }<br /> <br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>#results tr th </strong>{<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>padding</strong>: 1<strong>vw</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }<br /> <br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>#results tr td </strong>{<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>padding</strong>: 1<strong>vw</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<strong>transition</strong>: <strong>font-size </strong>0.2<strong>s</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }<br /> <br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>#results tr</strong>:<strong>not</strong>(:<strong>first-child</strong>):<strong>hover </strong>{<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>background-color</strong>: <strong>#F0F8FF</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>color</strong>: <strong>#000000</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>font-size</strong>: 2.25<strong>vw</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }<br /> <br /> &nbsp;&nbsp;&nbsp; &lt;/<strong>style</strong>&gt;<br /> &lt;/<strong>head</strong>&gt;<br /> &lt;<strong>body</strong>&gt;<br /> &lt;<strong>table </strong><strong>id=</strong><strong>"results"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>tr</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>th</strong>&gt;ID&lt;/<strong>th</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>th</strong>&gt;First Name&lt;/<strong>th</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>th</strong>&gt;Last Name&lt;/<strong>th</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>th</strong>&gt;Faculty Number&lt;/<strong>th</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>th</strong>&gt;Grade&lt;/<strong>th</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;/<strong>tr</strong>&gt;<br /> &lt;/<strong>table</strong>&gt;<br /> <em>&lt;!--&lt;script src="script.js"&gt;&lt;/script&gt;--&gt;<br /> </em>&lt;/<strong>body</strong>&gt;<br /> &lt;/<strong>html</strong>&gt;</p>
</td>
</tr>
</tbody>
</table>
<h3>Screenshots</h3>
<h2>5.&nbsp;&nbsp; Countries &amp; Towns</h2>
<h3>Create a Backend at kinvey.com</h3>
<p>Register at <strong>kinvey.com</strong>, create an application and two classes: <strong>Country(name)</strong> and <strong>Town(name, country)</strong>. Fill sample data for further use. Submit in the homework screenshots of your classes from kinvey.com.</p>
<h3>List Countries</h3>
<p>Create a JavaScript application (HTML + CSS + JS + jQuery) that loads and displays all countries from your application at Kinvey.com into a HTML page.</p>
<h3>Edit Countries</h3>
<p>Extend the previous application with add / edit / delete for countries.</p>
<h3>List Towns by Country</h3>
<p>Extend the previous application to show all towns when a certain country is selected.</p>
<h3>CRUD Towns</h3>
<p>Extend the previous application to implement add / edit / delete for towns.</p>
<h2>6.&nbsp;&nbsp; Venuemaster</h2>
<p>Write a JS program that displays information about venues and allows the user to buy a ticket. Use the following HTML to test your code:</p>
<table width="1361">
<tbody>
<tr>
<td width="1361">
<p>venuemaster.html</p>
</td>
</tr>
<tr>
<td width="1361">
<p>&lt;!DOCTYPE <strong>html</strong>&gt;</p>
<p>&lt;<strong>html </strong><strong>lang=</strong><strong>"en"</strong>&gt;</p>
<p>&lt;<strong>head</strong>&gt;</p>
<p>&nbsp; &lt;<strong>meta </strong><strong>charset=</strong><strong>"UTF-8"</strong>&gt;</p>
<p>&nbsp; &lt;<strong>title</strong>&gt;Venue Master&lt;/<strong>title</strong>&gt;</p>
<p>&nbsp; &lt;<strong>script </strong><strong>src=</strong><strong>"https://code.jquery.com/jquery-3.1.1.min.js"</strong>&gt;&lt;/<strong>script</strong>&gt;</p>
<p>&nbsp; &lt;<strong>style</strong>&gt;</p>
<p>&nbsp;&nbsp;&nbsp; <strong>#content </strong>{ <strong>width</strong>: 800<strong>px</strong>; }</p>
<p>&nbsp;&nbsp;&nbsp; .<strong>venue </strong>{ <strong>border</strong>: 1<strong>px solid black</strong>; <strong>margin</strong>: 0.5<strong>em</strong>; }</p>
<p>&nbsp;&nbsp;&nbsp; .<strong>venue-name </strong>{ <strong>background-color</strong>: <strong>beige</strong>; <strong>padding</strong>: 0.1<strong>em</strong>; <strong>display</strong>: <strong>block</strong>; <strong>font-size</strong>: 2<strong>em</strong>; <strong>padding-left</strong>: 1<strong>em</strong>; }</p>
<p>&nbsp;&nbsp;&nbsp; .<strong>venue-name input </strong>{ <strong>margin-right</strong>: 1<strong>em</strong>; }</p>
<p>&nbsp;&nbsp;&nbsp; .<strong>head </strong>{ <strong>background-color</strong>: <strong>beige</strong>; <strong>padding</strong>: 0.1<strong>em</strong>; <strong>padding-left</strong>: 1.5<strong>em</strong>; <strong>display</strong>: <strong>block</strong>; <strong>font-size</strong>: 1.5<strong>em</strong>; }</p>
<p>&nbsp;&nbsp;&nbsp; .<strong>description </strong>{ <strong>margin</strong>: 2<strong>em</strong>; }</p>
<p>&nbsp;&nbsp;&nbsp; <strong>table </strong>{ <strong>text-align</strong>: <strong>center</strong>; <strong>margin</strong>: 2<strong>em</strong>; }</p>
<p>&nbsp;&nbsp;&nbsp; <strong>td</strong>, <strong>th </strong>{ <strong>width</strong>: 100<strong>px</strong>; }</p>
<p>&nbsp;&nbsp;&nbsp; .<strong>purchase-info span </strong>{ <strong>display</strong>: <strong>inline-block</strong>; <strong>width</strong>: 100<strong>px</strong>; <strong>margin-left</strong>: 2<strong>em</strong>; <strong>margin-right</strong>: 2<strong>em</strong>; }</p>
<p>&nbsp;&nbsp;&nbsp; .<strong>ticket </strong>{ <strong>border</strong>: 1<strong>px solid black</strong>; <strong>text-align</strong>: <strong>center</strong>; <strong>overflow</strong>: <strong>hidden</strong>; }</p>
<p>&nbsp;&nbsp;&nbsp; .<strong>bl </strong>{ <strong>display</strong>: <strong>inline-block</strong>; <strong>font-size</strong>: 1.5<strong>em</strong>; <strong>margin</strong>: 1<strong>em </strong>3<strong>em </strong>1<strong>em </strong>3<strong>em</strong>; }</p>
<p>&nbsp;&nbsp;&nbsp; .<strong>left </strong>{ <strong>width</strong>: 600<strong>px</strong>; <strong>float</strong>:<strong>left</strong>; }</p>
<p>&nbsp;&nbsp;&nbsp; .<strong>right </strong>{ <strong>float</strong>:<strong>right</strong>; }</p>
<p>&nbsp; &lt;/<strong>style</strong>&gt;</p>
<p>&lt;/<strong>head</strong>&gt;</p>
<p>&lt;<strong>body</strong>&gt;</p>
<p>&lt;<strong>div </strong><strong>id=</strong><strong>"content"</strong>&gt;</p>
<p>&nbsp; &lt;<strong>div </strong><strong>id=</strong><strong>"date-control"</strong>&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;<strong>input </strong><strong>type=</strong><strong>"text" </strong><strong>id=</strong><strong>"venueDate" </strong><strong>placeholder=</strong><strong>"Enter date"</strong>&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;<strong>input </strong><strong>type=</strong><strong>"button" </strong><strong>id=</strong><strong>"getVenues" </strong><strong>value=</strong><strong>"List Venues"</strong>&gt;</p>
<p>&nbsp; &lt;/<strong>div</strong>&gt;</p>
<p>&nbsp; &lt;<strong>div </strong><strong>id=</strong><strong>"venue-info"</strong>&gt;</p>
<p>&nbsp; &lt;/<strong>div</strong>&gt;</p>
<p>&lt;/<strong>div</strong>&gt;</p>
<p>&lt;<strong>script </strong><strong>src=</strong><strong>"venuemaster.js"</strong>&gt;&lt;/<strong>script</strong>&gt;</p>
<p>&lt;<strong>script</strong>&gt;</p>
<p>&nbsp; <em>attachEvents</em>();</p>
<p>&lt;/<strong>script</strong>&gt;</p>
<p>&lt;/<strong>body</strong>&gt;</p>
<p>&lt;/<strong>html</strong>&gt;</p>
</td>
</tr>
</tbody>
</table>
<p>Submit only the attachEvents() function that attaches events and holds all program logic.</p>
<p>You can use the following Kinvey database and credentials to test your solution:</p>
<p>App ID: kid_BJ_Ke8hZg</p>
<p>User: guest</p>
<p>Password: pass</p>
<p>You can consult previous lectures about making requests to Kinvey databases: <a href="https://softuni.bg/downloads/svn/js-core/Sept-2016/JS-Apps-Nov-2016/4.%20JS-Apps-Async-Programming-Promises/4.%20JS-Apps-Async-Programming-and-Promises.pptx">Asynchronous Programming</a>. Note that certain requests are made to rpc/ instead of appdata/ &ndash; take care when copy/pasting code!</p>
<p>When the user clicks on the <strong>button</strong> with ID "<strong>getVenues</strong>", take the value of the input field with ID "<strong>venueDate</strong>" and make a POST request to rpc/kid_BJ_Ke8hZg/custom/calendar?query={date} (replace the highlighted part with the relevant value). The server will respond with and <strong>array</strong>, containing the IDs of available venues for that date. Use those IDs to obtain information from the server about <strong>each</strong> of the venues &ndash; make a GET request to appdata/kid_BJ_Ke8hZg/venues/{_id} (replace the highlighted part with the relevant value). The server will respond with an object in the following format:</p>
<p>{ name: <em>String</em>,</p>
<p>&nbsp; description: <em>String</em>,</p>
<p>&nbsp; startingHour: <em>String</em>,</p>
<p>&nbsp; price: <em>Number</em> }</p>
<p>Compose a list with all venues and display it on the page inside the &lt;div&gt; with ID "<strong>venue-info</strong>". Use the following HTML to format the results:</p>
<table width="1361">
<tbody>
<tr>
<td width="1361">
<p>Venue Template</p>
</td>
</tr>
<tr>
<td width="1361">
<p>&lt;<strong>div </strong><strong>class=</strong><strong>"venue" </strong><strong>id=</strong><strong>"</strong>{venue._id}<strong>"</strong>&gt;</p>
<p>&nbsp; &lt;<strong>span </strong><strong>class=</strong><strong>"venue-name"</strong>&gt;&lt;<strong>input </strong><strong>class=</strong><strong>"info" </strong><strong>type=</strong><strong>"button" </strong><strong>value=</strong><strong>"More info"</strong>&gt;{venue.name}&lt;/<strong>span</strong>&gt;</p>
<p>&nbsp; &lt;<strong>div </strong><strong>class=</strong><strong>"venue-details" </strong><strong>style=</strong><strong>"</strong><strong>display</strong>: <strong>none</strong>;<strong>"</strong>&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;<strong>table</strong>&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>tr</strong>&gt;&lt;<strong>th</strong>&gt;Ticket Price&lt;/<strong>th</strong>&gt;&lt;<strong>th</strong>&gt;Quantity&lt;/<strong>th</strong>&gt;&lt;<strong>th</strong>&gt;&lt;/<strong>th</strong>&gt;&lt;/<strong>tr</strong>&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>tr</strong>&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>td </strong><strong>class=</strong><strong>"venue-price"</strong>&gt;{venue.price} lv&lt;/<strong>td</strong>&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>td</strong>&gt;&lt;<strong>select </strong><strong>class=</strong><strong>"quantity"</strong>&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>option </strong><strong>value=</strong><strong>"1"</strong>&gt;1&lt;/<strong>option</strong>&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>option </strong><strong>value=</strong><strong>"2"</strong>&gt;2&lt;/<strong>option</strong>&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>option </strong><strong>value=</strong><strong>"3"</strong>&gt;3&lt;/<strong>option</strong>&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>option </strong><strong>value=</strong><strong>"4"</strong>&gt;4&lt;/<strong>option</strong>&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>option </strong><strong>value=</strong><strong>"5"</strong>&gt;5&lt;/<strong>option</strong>&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/<strong>select</strong>&gt;&lt;/<strong>td</strong>&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>td</strong>&gt;&lt;<strong>input </strong><strong>class=</strong><strong>"purchase" </strong><strong>type=</strong><strong>"button" </strong><strong>value=</strong><strong>"Purchase"</strong>&gt;&lt;/<strong>td</strong>&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/<strong>tr</strong>&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;/<strong>table</strong>&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;<strong>span </strong><strong>class=</strong><strong>"head"</strong>&gt;Venue description:&lt;/<strong>span</strong>&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;<strong>p </strong><strong>class=</strong><strong>"description"</strong>&gt;{venue.description}&lt;/<strong>p</strong>&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;<strong>p </strong><strong>class=</strong><strong>"description"</strong>&gt;Starting time: {venue.startingHour}&lt;/<strong>p</strong>&gt;</p>
<p>&nbsp; &lt;/<strong>div</strong>&gt;</p>
<p>&lt;/<strong>div</strong>&gt;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;Each item in the list has a button "<strong>More info</strong>", that changes the visibility of the detailed description for the corresponding venue &ndash; hide all descriptions (set style to "<strong>display: none</strong>") and show the current description (set style to "<strong>display: block</strong>"). The detailed view has a numeric drop-down and a button "<strong>Buy tickets</strong>". When this button is clicked, take the user to the confirmation page &ndash; change the contents of the "<strong>#venue-info</strong>" div, using the following HTML:</p>
<table width="1361">
<tbody>
<tr>
<td width="1361">
<p>Confirmation Template</p>
</td>
</tr>
<tr>
<td width="1361">&lt;<strong>span </strong><strong>class=</strong><strong>"head"</strong>&gt;Confirm purchase&lt;/<strong>span</strong>&gt;&lt;<strong>div </strong><strong>class=</strong><strong>"purchase-info"</strong>&gt;&nbsp; &lt;<strong>span</strong>&gt;{name}&lt;/<strong>span</strong>&gt;&nbsp; &lt;<strong>span</strong>&gt;{qty} x {price}&lt;/<strong>span</strong>&gt;&nbsp; &lt;<strong>span</strong>&gt;Total: {qty * price} lv&lt;/<strong>span</strong>&gt;&nbsp; &lt;<strong>input </strong><strong>type=</strong><strong>"button" </strong><strong>value=</strong><strong>"Confirm"</strong>&gt;&lt;/<strong>div</strong>&gt;</td>
</tr>
</tbody>
</table>
<p>The final step is the confirmation of the purchase &ndash; when the user clicks on the button with ID "<strong>confirm</strong>", make a POST request to rpc/kid_BJ_Ke8hZg/custom/purchase?venue={_id}&amp;qty={qty} &ndash; the server will return an object, containing an HTML fragment in it&rsquo;s html property. Display that fragment inside "<strong>#venue-info</strong>" along with the text "<strong>You may print this page as your ticket</strong>".</p>
<h3>Hints</h3>
<p>The service at the given address will respond with valid information for dates "23-11", "24-11", "25-11", "26-11" and "27-11", in this exact format. Use these to test your solution (no validation is required).</p>
<h3>Examples</h3>
<h2>7.&nbsp;&nbsp; ***Secret Knock</h2>
<p>Your task is to perform the Secret Knock. The Secret Knock is a secret knocking technique that is performed with requests, responses and promises. First, you will use Kinvey.</p>
<p>The app credentials are:</p>
<ul>
<li>App id / key: kid_BJXTsSi-e</li>
<li>App secret: 447b8e7046f048039d95610c1b039390</li>
</ul>
<p>The guest user is:</p>
<ul>
<li>Username: guest</li>
<li>Password: guest</li>
</ul>
<p>You will need to log in before you perform any kind of action. Next you will have to send various requests <strong>with queries</strong>. Now a query is a list of parameters added to the URL of the request. Here is the base URL for the requests:<br /> </p>
<p>https://baas.kinvey.com/appdata/kid_BJXTsSi-e/knock</p>
<p>&nbsp;</p>
<p>And now you have to add the first query, which is &ldquo;Knock Knock.&rdquo; to the URL. Do it like this:</p>
<p>https://baas.kinvey.com/appdata/kid_BJXTsSi-e/knock?query=Knock Knock.</p>
<p>If you send a <strong>GET request</strong> to this URL with this query, you will receive a response with an <strong>answer</strong> from the server, and the <strong>next message</strong>. Change the <strong>query</strong> with the <strong>next message</strong> in line, and continue this process until you receive a response <strong>with no next message</strong>. Print the <strong>answer</strong> and the <strong>next message</strong> after each successful request on the console, and you&rsquo;ll be able to see the magic of the Secret Knock.</p>
<h2>8.&nbsp;&nbsp; Wild Wild West</h2>
<p>Write the REST services for a simple Western game. Create a collection players(name, money, bullets) to hold information about the players in the game.</p>
<ul>
<li>name - string representing the name of the current player.</li>
<li>money - integer number representing the current player&rsquo;s money.</li>
<li>bullets - integer number representing the current bullets of the player.</li>
</ul>
<h3>HTML and JS</h3>
<p>You will be provided with a skeleton project containing an HTML template and some JS files, the loadCanvas.js is simple implementation for the game, your job is to attach events to all the buttons and make the needed AJAX requests. You are provided with a file to write your code:</p>
<table width="1361">
<tbody>
<tr>
<td width="1361">
<p>attachEvents.js</p>
</td>
</tr>
<tr>
<td width="1361">
<p><strong>function </strong><em>attachEvents</em>() {<br /> &nbsp;&nbsp; <em>//</em><strong><em>TODO<br /> </em></strong>}</p>
</td>
</tr>
</tbody>
</table>
<p>When the page is loaded a GET request should be sent to the server to get all players and load them in the #players div, an example entry is left in the HTML to demonstrate the HTML representation of a player and his placement.</p>
<p>Whenever the [Save] button is pressed the progress of the current player (if there is one) should be saved (a PUT request sent to the server with the new data), the canvas and buttons [Save] and [Reload] should be hidden and the clearInterval should be called on the canvas.intervarId property (used for the main loop of the game).</p>
<p>Whenever the [Reload] button is pressed the player&rsquo;s money should be <strong>reduced by 60</strong> and his bullets should be <strong>set to 6</strong>.</p>
<p>Whenever the [Add Player] button is clicked a new Player with the name specified in the corresponding input should be created and the players should be reloaded to display the new entry. Each new player starts with 500 Money and 6 bullets.</p>
<p>Pressing the [Play] button on a player should first call the<strong> [Save]</strong> button, then display the canvas, [Save] and [Reload] buttons and after that call the loadCanvas function (from the loadCanvas.js) and pass to it the <strong>new player</strong> as an <strong>object</strong> (containing properties name, money and bullets).</p>
<p>When a player&rsquo;s [Delete] button is pressed the player should be deleted (both from the HTML and from the server).</p>
<h3>Examples</h3>