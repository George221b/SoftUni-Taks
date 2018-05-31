<h1>Exercises: Classes and Their Members</h1>
<p>Problems for exercises and homework for the <a href="https://softuni.bg/courses/javascript-advanced">&ldquo;JavaScript Advanced&rdquo; course @ SoftUni</a>. Submit your solutions in the SoftUni judge system at <a href="https://judge.softuni.bg/Contests/340/">https://judge.softuni.bg/Contests/340/</a>.</p>
<h2>1.&nbsp;&nbsp; Data Class</h2>
<p>Write a JS class that holds data about an HTTP request. It has the following properties:</p>
<ul>
<li>method (String)</li>
<li>uri (String)</li>
<li>version (String)</li>
<li>message (String)</li>
<li>response (String)</li>
<li>fulfilled (Boolean)</li>
</ul>
<p>The first four properties (<strong>method</strong>, <strong>uri</strong>, <strong>version</strong>, <strong>message</strong>) are set trough the <strong>constructor</strong>, in the listed order. The <strong>response</strong> property is initialized to undefined and the <strong>fulfilled</strong> property is initially set to false.</p>
<h3>Input / Output</h3>
<p>The constructor of your class will receive valid parameters. There is no output.</p>
<p>Submit the class definition as is, <strong>without</strong> wrapping it in any function.</p>
<h3>Examples</h3>
<table width="1361">
<tbody>
<tr>
<td width="680">
<p>Sample Input</p>
</td>
<td width="680">
<p>Resulting object</p>
</td>
</tr>
<tr>
<td width="680">
<p>let myData = new Request('GET', 'http://google.com', 'HTTP/1.1', '')</p>
</td>
<td width="680">
<p>{ method: 'GET',</p>
<p>&nbsp; uri: 'http://google.com',</p>
<p>&nbsp; version: 'HTTP/1.1',</p>
<p>&nbsp; message: '',</p>
<p>&nbsp; response: undefined,</p>
<p>&nbsp; fulfilled: false }</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>Using ES6 syntax, a class can be defined similar to a function, using the class keyword:</p>
<p>At this point, the class can already be <strong>instantiated</strong>, but it won&rsquo;t hold anything useful, since it doesn&rsquo;t have a constructor. A <strong>constructor</strong> is a function that initializes the object&rsquo;s context and attaches values to it. It is defined with the keyword constructor inside the body of the class definition and it follows the syntax of regular JS functions &ndash; it can take arguments and execute logic. Any variables we want to be attached to the <strong>instance</strong> must be prefixed with the this identifier:</p>
<p>The description mentions some of the properties need to be set via the constructor &ndash; this means the constructor must receive them as parameters. We modify it to take four named parameters that we then assign to the local variables:</p>
<p>Note the input parameters have the same names as the instance variables &ndash; this isn&rsquo;t necessary, but it&rsquo;s easier to read. There will be no name collision, because the this identifier tells the interpreter to look for a variable in a different context, so this.method is not the same as method.</p>
<p>Our class is complete and can be submitted to the Judge.</p>
<h2>2.&nbsp;&nbsp; Tickets</h2>
<p>Write a JS program that manages a database of tickets. A ticket has a <strong>destination, </strong>a <strong>price</strong> and a <strong>status</strong>. Your program will receive <strong>two argument</strong> &ndash; the first is an <strong>array of strings</strong> for ticket descriptions and the second is a <strong>string</strong>, representing a <strong>sorting criteria</strong>. The ticket descriptions have the following format:</p>
<p>&lt;destinationName&gt;|&lt;price&gt;|&lt;status&gt;</p>
<p>Store each ticket and at the end of execution <strong>return</strong> a sorted summary of all tickets, sorted by either <strong>destination</strong>, <strong>price</strong> or <strong>status</strong>, depending on the <strong>second parameter</strong> that your program received. Always sort in ascending order (default behavior for <strong>alphabetical</strong> sort). If two tickets compare the same, use order of appearance. See the examples for more information.</p>
<h3>Input</h3>
<p>Your program will receive two parameters &ndash; an array of strings and a single string.</p>
<h3>Output</h3>
<p><strong>Return</strong> a <strong>sorted array</strong> of all the tickets that where registered.</p>
<h3>Examples</h3>
<table width="1360">
<tbody>
<tr>
<td width="605">
<p>Sample Input</p>
</td>
<td width="756">
<p>Output Array</p>
</td>
</tr>
<tr>
<td width="605">
<p>['Philadelphia|94.20|available',</p>
<p>&nbsp;'New York City|95.99|available',</p>
<p>&nbsp;'New York City|95.99|sold',</p>
<p>&nbsp;'Boston|126.20|departed'],</p>
<p>'destination'</p>
</td>
<td width="756">
<p>[ Ticket { destination: 'Boston',</p>
<p>&nbsp;&nbsp;&nbsp; price: 126.20,</p>
<p>&nbsp;&nbsp;&nbsp; status: 'departed' },</p>
<p>&nbsp; Ticket { destination: 'New York City',</p>
<p>&nbsp;&nbsp;&nbsp; price: 95.99,</p>
<p>&nbsp;&nbsp;&nbsp; status: 'available' },</p>
<p>&nbsp; Ticket { destination: 'New York City',</p>
<p>&nbsp;&nbsp;&nbsp; price: 95.99,</p>
<p>&nbsp;&nbsp;&nbsp; status: 'sold' },</p>
<p>&nbsp; Ticket { destination: 'Philadelphia',</p>
<p>&nbsp;&nbsp;&nbsp; price: 94.20,</p>
<p>&nbsp;&nbsp;&nbsp; status: 'available' } ]</p>
</td>
</tr>
<tr>
<td width="605">
<p>['Philadelphia|94.20|available',</p>
<p>&nbsp;'New York City|95.99|available',</p>
<p>&nbsp;'New York City|95.99|sold',</p>
<p>&nbsp;'Boston|126.20|departed'],</p>
<p>'status'</p>
</td>
<td width="756">
<p>[ Ticket { destination: 'Philadelphia',</p>
<p>&nbsp;&nbsp;&nbsp; price: 94.20,</p>
<p>&nbsp;&nbsp;&nbsp; status: 'available' },</p>
<p>&nbsp; Ticket { destination: 'New York City',</p>
<p>&nbsp;&nbsp;&nbsp; price: 95.99,</p>
<p>&nbsp;&nbsp;&nbsp; status: 'available' },</p>
<p>&nbsp; Ticket { destination: 'Boston',</p>
<p>&nbsp;&nbsp;&nbsp; price: 126.20,</p>
<p>&nbsp;&nbsp;&nbsp; status: 'departed' },</p>
<p>&nbsp; Ticket { destination: 'New York City',</p>
<p>&nbsp;&nbsp;&nbsp; price: 95.99,</p>
<p>&nbsp;&nbsp;&nbsp; status: 'sold' } ]</p>
</td>
</tr>
</tbody>
</table>
<h2>3.&nbsp;&nbsp; Unity</h2>
<p>Rats are uniting.</p>
<p>Create a class, Rat, which holds the functionality to unite with other objects of the same type. Make it so that the object holds all of the other objects it has connected to.</p>
<p>The class should have a <strong>name</strong>, which is a <strong>string</strong>, and it should be <strong>initialized with it</strong>.</p>
<p>The class should also hold a function unite(otherRat), which unites the <strong>first object</strong> with the <strong>given one</strong>. An object should store all of the objects it has united to. The function should only add the object if it is an object of the class Rat. In any other case it should <strong>do nothing</strong>.</p>
<p>The class should also hold a function getRats() which returns all the rats it has united to, in a list.</p>
<p>Implement functionality for toString() function&hellip; which returns a string representation of the object and all of the objects its united with, each on a new line. On the first line put the object&rsquo;s name and on the next several lines put the united objects&rsquo; names, each with a padding of &ldquo;<strong>##</strong>&rdquo;.</p>
<h3>Example</h3>
<table width="1329">
<tbody>
<tr>
<td width="1329">
<p>test.js</p>
</td>
</tr>
<tr>
<td width="1329">
<p><strong>let </strong><strong><em>test </em></strong>= <strong>new </strong>Rat(<strong>"Pesho"</strong>);<br /> <strong><em>console</em></strong>.log(<strong><em>test</em></strong>.toString()); <em>//Pesho<br /> <br /> </em><strong><em>console</em></strong>.log(<strong><em>test</em></strong>.getRats()); <em>//[]<br /> <br /> </em><strong><em>test</em></strong>.unite(<strong>new </strong>Rat(<strong>"Gosho"</strong>));<br /> <strong><em>test</em></strong>.unite(<strong>new </strong>Rat(<strong>"Sasho"</strong>));<br /> <strong><em>console</em></strong>.log(<strong><em>test</em></strong>.getRats());<br /> <em>//[ Rat { name: 'Gosho', unitedRats: [] },<br /> //&nbsp; Rat { name: 'Sasho', unitedRats: [] } ]<br /> <br /> </em><strong><em>console</em></strong>.log(<strong><em>test</em></strong>.toString());<br /> <em>// Pesho<br /> // ##Gosho<br /> // ##Sasho</em></p>
</td>
</tr>
</tbody>
</table>
<h3>&nbsp;</h3>
<h3>Hints</h3>
<p>Submit your solution as a class representation only! No need for IIFEs or wrapping of classes.</p>
<h2>4.&nbsp;&nbsp; Length Limit</h2>
<p>Create a class, Stringer, which holds <strong>single string</strong> and a <strong>length</strong> property. The class should be initialized with a <strong>string</strong>, and an <strong>initial length. </strong>The class should always keep the <strong>initial state</strong> of its <strong>given</strong> <strong>string</strong>.</p>
<p>Name the two properties innerString and innerLength.</p>
<p>There should also be functionality for increasing and decreasing the initial <strong>length</strong> property.<br /> Implement function increase(length) and decrease(length), which manipulate the length property with the <strong>given value</strong>.</p>
<p>The length property is <strong>a numeric value</strong> and should not fall below <strong>0</strong>. It should not throw any errors, but if an attempt to decrease it below 0 is done, it should be automatically set to <strong>0</strong>.</p>
<p>You should also implement functionality for toString() function, which returns the string, the object was initialized with. If the length of the string is greater than the <strong>length property</strong>, the string should be cut to from right to left, so that it has the <strong>same length</strong> as the <strong>length property</strong>, and you should add <strong>3 dots</strong> after it, if such <strong>truncation</strong> was <strong>done</strong>.</p>
<p>If the length property is <strong>0</strong>, just return <strong>3 dots.</strong></p>
<h3>Examples</h3>
<table width="1329">
<tbody>
<tr>
<td width="1329">
<p>test.js</p>
</td>
</tr>
<tr>
<td width="1329">
<p><strong>let </strong><strong><em>test </em></strong>= <strong>new </strong>Stringer(<strong>"Test"</strong>, 5);<br /> <strong><em>console</em></strong>.log(<strong><em>test</em></strong>.toString()); <em>//Test<br /> <br /> </em><strong><em>test</em></strong>.decrease(3);<br /> <strong><em>console</em></strong>.log(<strong><em>test</em></strong>.toString()); <em>//Te...<br /> <br /> </em><strong><em>test</em></strong>.decrease(5);<br /> <strong><em>console</em></strong>.log(<strong><em>test</em></strong>.toString()); <em>//...<br /> <br /> </em><strong><em>test</em></strong>.increase(4);<br /> <strong><em>console</em></strong>.log(<strong><em>test</em></strong>.toString()); <em>//Test</em></p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>Store the initial string in a property, and do not change it. Upon calling the toString() function, truncate it to the <strong>desired value</strong> and return it.</p>
<p>Submit your solution as a class representation only! No need for IIFEs or wrapping of classes.</p>
<h2>5.&nbsp;&nbsp; Extensible Class</h2>
<p><strong>Revisit</strong> the problem Extensible Object from Object Composition. Refactor the code so that instead of a single instance, you deliver a <strong>class</strong> that can be <strong>extended</strong>. The class has an extend(template) method that would copy all of the properties of <strong>template</strong> to the <strong>instance</strong> (not to all instances, just the one from which the method was called) and if the property is a function, add it to the object&rsquo;s <strong>prototype</strong> instead.</p>
<p>In addition, the base class needs to have an <strong>ID property</strong> that is <strong>unique</strong> and <strong>autoincremented</strong> sequentally for every new instance.</p>
<h3>Input / Output</h3>
<p>The extend() function of your object will receive a valid object as <strong>input parameter</strong>, and has <strong>no</strong> output.</p>
<p>Structure your code as an <strong>IIFE</strong> that <strong>returns</strong> the class.</p>
<h3>Examples</h3>
<table width="1361">
<tbody>
<tr>
<td width="680">
<p>Sample Input</p>
</td>
<td width="680">
<p>Output</p>
</td>
</tr>
<tr>
<td width="680">
<p>let obj1 = new Extensible();</p>
<p>let obj2 = new Extensible();</p>
<p>let obj3 = new Extensible();</p>
<p>console.log(obj1.id);</p>
<p>console.log(obj2.id);</p>
<p>console.log(obj3.id);</p>
</td>
<td width="680">
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>0</p>
<p>1</p>
<p>2</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="1361">
<tbody>
<tr>
<td width="680">
<p>Extensible object</p>
</td>
<td width="680">
<p>Resulting object</p>
</td>
</tr>
<tr>
<td width="680">
<p>obj1: {</p>
<p>&nbsp; __proto__: {</p>
<p>&nbsp;&nbsp;&nbsp; extend: function () {&hellip;}</p>
<p>&nbsp; },</p>
<p>&nbsp; id: 0</p>
<p>}</p>
</td>
<td rowspan="3" width="680">
<p>myObj: {</p>
<p>&nbsp; __proto__: {</p>
<p>&nbsp;&nbsp;&nbsp; extend: function () {&hellip;},</p>
<p>&nbsp;&nbsp;&nbsp; extensionMethod: function () {&hellip;}</p>
<p>&nbsp; },</p>
<p>&nbsp; id: 0,</p>
<p>&nbsp; extensionProperty: 'someString'</p>
<p>}</p>
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="680">
<p>Template object</p>
</td>
</tr>
<tr>
<td width="680">
<p>template: {</p>
<p>&nbsp; extensionMethod: function () {&hellip;},</p>
<p>&nbsp; extensionProperty: 'someString'</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>You may have to keep track of the last assigned ID in a <strong>closure</strong> that is accessible by the constructor. Constructor functions offer direct access to their prototypes &ndash; you can view and modify them with <em>ClassName</em>.prototype.</p>
<h2>6.&nbsp;&nbsp; Sorted List</h2>
<p>Revisit the problem Sorted List from Object Composition. Refactor the code so instead of an instance, you deliver a <strong>class</strong>. Implement a <strong>collection</strong>, which keeps a list of numbers, sorted in <strong>ascending order</strong>. It must support the following functionality:</p>
<ul>
<li>add(elemenent) &ndash; adds a new element to the collection</li>
<li>remove(index) &ndash; removes the element at position <strong>index</strong></li>
<li>get(index) &ndash; returns the value of the element at position <strong>index</strong></li>
<li>size &ndash; number of elements stored in the collection</li>
</ul>
<p>The <strong>correct order</strong> of the elements must be kept <strong>at all times</strong>, regardless of which operation is called. <strong>Removing</strong> and <strong>retrieving</strong> elements <strong>shouldn&rsquo;t</strong> work if the provided index points <strong>outside the length</strong> of the collection (either throw an error or do nothing). Note the <strong>size</strong> of the collection is <strong>not</strong> a function.</p>
<h3>Input / Output</h3>
<p>All function that expect <strong>input</strong> will receive data as <strong>parameters</strong>. Functions that have <strong>validation</strong> will be tested with both <strong>valid and invalid</strong> data. Any result expected from a function should be <strong>returned</strong> as it&rsquo;s result.</p>
<p>Submit the class definition as is, <strong>without</strong> wrapping it in any function.</p>
<h2>7.&nbsp;&nbsp; Instance Validation</h2>
<p>Write a class for a checking account that validates it&rsquo;s created with valid parameters. A CheckingAccount has a clientId, email, firstName, lastName all set trough the constructor and an array of products that is initially empty. Each parameter must meet specific requirements:</p>
<ul>
<li>clientId &ndash; must be a string representing a 6-digit number; if invalid, throw a TypeError with the message "Client ID must be a 6-digit number"</li>
<li>email &ndash; must contain at least one alphanumeric character, followed by the @ symbol, followed by one or more letters or periods; all letters must be Latin; if invalid, throw a TypeError with message "Invalid e-mail"</li>
<li>firstName, lastName &ndash; must be at least 3 and at most 20 characters long, containing only Latin letters; if the <strong>length</strong> is invalid, throw a TypeError with message "{<strong>First</strong>/<strong>Last</strong>} name must be between 3 and 20 characters long"; if invalid <strong>characters</strong> are used, throw a TypeError with message "{<strong>First</strong>/<strong>Last</strong>} name must contain only Latin characters" (replace <strong>First</strong>/<strong>Last</strong> with the relevant word);</li>
</ul>
<p>All checks must happen in the order in which they are listed &ndash; if more than one parameter is invalid, throw an error for the first encountered. Note that error messages must be exact.</p>
<p>Submit your solution containing a single class definition.</p>
<h3>Examples</h3>
<table width="1361">
<tbody>
<tr>
<td width="1361">
<p>Sample Input</p>
</td>
</tr>
<tr>
<td width="1361">
<p>let acc = new CheckingAccount('1314', 'ivan@some.com', 'Ivan', 'Petrov')</p>
</td>
</tr>
<tr>
<td width="1361">
<p>Output</p>
</td>
</tr>
<tr>
<td width="1361">
<p>TypeError: Client ID must be a 6-digit number</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="1361">
<tbody>
<tr>
<td width="1361">
<p>Sample Input</p>
</td>
</tr>
<tr>
<td width="1361">
<p>let acc = new CheckingAccount('131455', 'ivan@', 'Ivan', 'Petrov')</p>
</td>
</tr>
<tr>
<td width="1361">
<p>Output</p>
</td>
</tr>
<tr>
<td width="1361">
<p>TypeError: Invalid e-mail</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="1361">
<tbody>
<tr>
<td width="1361">
<p>Sample Input</p>
</td>
</tr>
<tr>
<td width="1361">
<p>let acc = new CheckingAccount('131455', 'ivan@some.com', 'I', 'Petrov')</p>
</td>
</tr>
<tr>
<td width="1361">
<p>Output</p>
</td>
</tr>
<tr>
<td width="1361">
<p>TypeError: First name must be between 3 and 20 characters long</p>
</td>
</tr>
<tr>
<td width="1361">
<p>Sample Input</p>
</td>
</tr>
<tr>
<td width="1361">
<p>let acc = new CheckingAccount('131455', 'ivan@some.com', 'Ivan', 'P3trov')</p>
</td>
</tr>
<tr>
<td width="1361">
<p>Output</p>
</td>
</tr>
<tr>
<td width="1361">
<p>TypeError: "First name must contain only Latin characters</p>
</td>
</tr>
</tbody>
</table>
<h1>Classes Interacting with DOM Elements</h1>
<h2>8.&nbsp;&nbsp; View Model</h2>
<p>Do you remember the sharedObject problem from unit testing, we're going to build upon the idea and create an object that ensures a set of DOM elements and a JS object share the same state.</p>
<p>We need to create a class Textbox that represents one or more <strong>HTML input</strong> elements with type="text". The constructor takes as parameters a <strong>selector</strong> and a <strong>regex</strong> for invalid symbols.</p>
<p>Textbox elements created from the class should have:</p>
<ul>
<li>public property value (has getters and setters)</li>
<li>private property _elements containing the set of elements matching the selector</li>
<li>public getter elements for the private _elements property</li>
<li>private property _invalidSymbols - a regex used for validating the textbox value</li>
<li>method isValid() - if the _invalidSymbols regex can be matched in the current textbox value return false, otherwise return true.</li>
</ul>
<p>All _elements values and the value property should be linked. If the value of an element from _elements changes all other elements' values and the value property should instantly reflect it, likewise should happen if the value property changes.</p>
<h3>Constraints</h3>
<ul>
<li>Selectors will always point to input elements with type text.</li>
</ul>
<h3>Example</h3>
<p>To help you test your code, you're provided with an <strong>HTML</strong> template:</p>
<table width="1328">
<tbody>
<tr>
<td width="1329">
<p>view-model.html</p>
</td>
</tr>
<tr>
<td width="1329">
<p>&lt;!DOCTYPE <strong>html</strong>&gt;<br /> &lt;<strong>html </strong><strong>lang=</strong><strong>"en"</strong>&gt;<br /> &lt;<strong>head</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>meta </strong><strong>charset=</strong><strong>"UTF-8"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>title</strong>&gt;Title&lt;/<strong>title</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>script </strong><strong>src=</strong><strong>"https://code.jquery.com/jquery-3.1.1.min.js"</strong>&gt;&lt;/<strong>script</strong>&gt;<br /> &lt;/<strong>head</strong>&gt;<br /> &lt;<strong>body</strong>&gt;<br /> &lt;<strong>div </strong><strong>id=</strong><strong>"wrapper"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>input </strong><strong>type=</strong><strong>"text" </strong><strong>class=</strong><strong>"textbox"</strong>/&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>input </strong><strong>type=</strong><strong>"text" </strong><strong>class=</strong><strong>"textbox"</strong>/&gt;<br /> &lt;/<strong>div</strong>&gt;<br /> &lt;<strong>script </strong><strong>src=</strong><strong>"view-model.js" </strong><strong>defer</strong>&gt;&lt;/<strong>script</strong>&gt;<br /> &lt;/<strong>body</strong>&gt;<br /> &lt;/<strong>html</strong>&gt;</p>
</td>
</tr>
</tbody>
</table>
<p>And an example <strong>JS</strong> <strong>skeleton</strong>:</p>
<table width="1328">
<tbody>
<tr>
<td width="1329">
<p>view-model.js</p>
</td>
</tr>
<tr>
<td width="1329">
<p><strong>class </strong>Textbox {...}<br /> <br /> <strong>let </strong><strong><em>textbox </em></strong>= <strong>new </strong>Textbox(<strong>".textbox"</strong>,/[^a-zA-Z0-9]/);</p>
<strong>let </strong><strong><em>inputs </em></strong>= $(<strong>'.textbox'</strong>);<br /> <br /> <strong><em>inputs</em></strong>.on(<strong>'input'</strong>,<strong>function</strong>(){<strong>console</strong>.log(<strong><em>textbox</em></strong>.value);});</td>
</tr>
</tbody>
</table>
<p>Here is an example output in the browser:</p>
<p>And the isValid function.</p>
<p>Submit in the judge <strong>ONLY</strong> the code for your Textbox class.</p>
<h3>Hints</h3>
<ul>
<li>Pay attention to what event you use, different events trigger on different conditions. You want an event that is directly linked to changes in the value of an input element.</li>
<li>Pay close attention to the value of this when writing event handler functions.</li>
</ul>
<h2>9.&nbsp;&nbsp; *Custom Form</h2>
<p>Using the Textbox class from last task, create a class Form that takes as parameters elements from class Textbox.</p>
<p>The Form class should follow these requirements:</p>
<ul>
<li>The Form should a private property _element consisting of a div element with class="form".</li>
<li>The constructor should be able to take different amount of Textbox</li>
<li>The constructor should validate that the objects are indeed of class Textbox, if an invalid parameter is passed an Error should be thrown.</li>
<li>In case all passed objects are correct, the Form should <strong>append</strong> each of them to its _element - in order of receiving them.</li>
<li>The Form should have a private property _textboxes containing all textboxes passed in.</li>
<li>The Form should have a submit() method, when the submit method is called the following should happen:
<ul>
<li>The method should set all valid Textboxes (textboxes whose isValid method returns <strong>true</strong>) borders to "2px solid green" while setting all invalid Textboxes borders to "2px solid red".</li>
<li>If all Textboxes are valid - returns <strong>true</strong>, otherwise returns <strong>false</strong>.</li>
</ul>
</li>
<li>The Form should have an attach(selector) method which attaches it to a passed in selector.</li>
</ul>
<h3>Constraints</h3>
<ul>
<li>Selectors will always point to input elements with type text.</li>
</ul>
<h3>Example</h3>
<p>To help you test your code, you're provided with an <strong>HTML</strong> template:</p>
<table width="1328">
<tbody>
<tr>
<td width="1329">
<p>form.html</p>
</td>
</tr>
<tr>
<td width="1329">
<p>&lt;!DOCTYPE <strong>html</strong>&gt;<br /> &lt;<strong>html </strong><strong>lang=</strong><strong>"en"</strong>&gt;<br /> &lt;<strong>head</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>meta </strong><strong>charset=</strong><strong>"UTF-8"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>title</strong>&gt;Form&lt;/<strong>title</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>script </strong><strong>src=</strong><strong>"https://code.jquery.com/jquery-3.1.1.min.js"</strong>&gt;&lt;/<strong>script</strong>&gt;<br /> &lt;/<strong>head</strong>&gt;<br /> &lt;<strong>body</strong>&gt;<br /> &lt;<strong>div </strong><strong>id=</strong><strong>"wrapper"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>span</strong>&gt;I am Wrapper&lt;/<strong>span</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>input </strong><strong>type=</strong><strong>"text" </strong><strong>id=</strong><strong>"username"</strong>/&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>input </strong><strong>type=</strong><strong>"text" </strong><strong>id=</strong><strong>"password"</strong>/&gt;<br /> &lt;/<strong>div</strong>&gt;<br /> &lt;<strong>div </strong><strong>id=</strong><strong>"root"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>span</strong>&gt;I am Root&lt;/<strong>span</strong>&gt;<br /> &lt;/<strong>div</strong>&gt;<br /> &lt;<strong>script </strong><strong>src=</strong><strong>"form.js" </strong><strong>defer</strong>&gt;&lt;/<strong>script</strong>&gt;<br /> &lt;/<strong>body</strong>&gt;<br /> &lt;/<strong>html</strong>&gt;</p>
</td>
</tr>
</tbody>
</table>
<p>And an example <strong>JS</strong> <strong>skeleton</strong>:</p>
<table width="1328">
<tbody>
<tr>
<td width="1329">
<p>form.js</p>
</td>
</tr>
<tr>
<td width="1329"><strong>let </strong><strong><em>result </em></strong>= (<strong>function</strong>() {<br /> <br /> &nbsp;&nbsp;&nbsp; <strong>class </strong>Textbox {...}&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;<strong>class </strong>Form {...}<br /> <br /> &nbsp;&nbsp;&nbsp; <strong>return </strong>{&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>Textbox</strong>: Textbox,&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>Form</strong>: Form&nbsp;&nbsp;&nbsp; }}())<br /> <br /> &nbsp; <strong>let </strong><strong><em>Textbox </em></strong>= <strong><em>result</em></strong>.Textbox;<br /> <strong>&nbsp; let </strong><strong><em>Form </em></strong>= <strong><em>result</em></strong>.Form;<br /> <strong>&nbsp; let </strong><strong><em>username </em></strong>= <strong>new </strong>Textbox(<strong>"#username"</strong>,/[^a-zA-Z0-9]/);&nbsp; <strong>let </strong><strong><em>password </em></strong>= <strong>new </strong>Textbox(<strong>"#password"</strong>,/[^a-zA-Z]/);&nbsp; <strong><em>username</em></strong>.value = <strong>"username"</strong>;&nbsp; <strong><em>password</em></strong>.value = <strong>"password2"</strong>;&nbsp; <strong>let </strong><strong><em>form </em></strong>= <strong>new </strong>Form(<strong><em>username</em></strong>,<strong><em>password</em></strong>);&nbsp; <strong><em>form</em></strong>.attach(<strong>"#root"</strong>);</td>
</tr>
</tbody>
</table>
<p>And here's an example in the browser:</p>
<p>And after using Form.attach()</p>
<p>You need to submit <strong>ONLY the IIFE </strong>(without the "let result =") which returns an object with two properties Textbox and Form representing the above mentioned classes.</p>