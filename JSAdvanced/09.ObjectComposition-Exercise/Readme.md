<h1>Exercises: Objects, Inheritance and Prototypes</h1>
<p>Problems for exercises and homework for the <a href="https://softuni.bg/courses/javascript-advanced">&ldquo;JavaScript Advanced&rdquo; course @ SoftUni</a>. Submit your solutions in the SoftUni judge system at <a href="https://judge.softuni.bg/Contests/301/">https://judge.softuni.bg/Contests/301/</a>.</p>
<h2>1.&nbsp;&nbsp; Array extension</h2>
<p><strong>Extend</strong> the build-in <strong>Array</strong> object with additional functionality. Implement the following functionality:</p>
<ul>
<li>last() &ndash; returns the last element of the array</li>
<li>skip(n) &ndash; returns a new array which includes all original elements, except the first <strong>n</strong> elements; <strong>n</strong> is a <strong>Number</strong> parameter</li>
<li>take(n) &ndash; returns a new array containing the first <strong>n</strong> elements from the original array; <strong>n</strong> is a <strong>Number</strong> parameter</li>
<li>sum() &ndash; returns a sum of all array elements</li>
<li>average() &ndash; returns the average of all array elements</li>
</ul>
<h3>Input / Output</h3>
<p><strong>Input</strong> for functions that expect it will be passed as valid <strong>parameters</strong>. <strong>Output</strong> from functions should be their <strong>return</strong> value.</p>
<p>Structure your code as an <strong>IIFE</strong>.</p>
<h3>Hints</h3>
<p>If we have an <strong>instance</strong> of and array, since we know it&rsquo;s an object, adding new properties to it is pretty straightforward:</p>
<p>This however, only adds our new function to this instance. To add all functions just one time and have them work on <strong>all arrays</strong> is not much more complicated, we just have to attach them to Array&rsquo;s <strong>prototype</strong> instead:</p>
<p>With such a declaration, we gain access to the context of the calling instance via this. We can then easily access indexes and other existing properties. Don&rsquo;t forget we don&rsquo;t want to modify the exiting array, but to create a new one:</p>
<p>Note these functions do not have any error checking &ndash; if <strong>n</strong> is negative or outside the bounds of the array, and exception will be thrown, so take care when using them, or add your own validation. The last two functions require a little bit of arithmetic to be performed:</p>
<p>To test our program in the Judge, we need to wrap it in an IIFE, like it&rsquo;s shown on the right. There is no return value, since the code execution results in functionality being added to and existing object, so they take effect instantly. We are ready to submit our solution.</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<h2>2.&nbsp;&nbsp; Construction Crew</h2>
<p>Write a JS program that <strong>receives</strong> a worker <strong>object</strong> as a <strong>parameter</strong> and modifies its properties. Workers have the following structure:</p>
<p>{ weight: Number,</p>
<p>&nbsp; experience: Number,</p>
<p>&nbsp; bloodAlcoholLevel: Number,</p>
<p>&nbsp; handsShaking: Boolean }</p>
<p><strong>Weight</strong> is expressed in <strong>kilograms</strong>, <strong>experience</strong> in <strong>years</strong> and <strong>bloodAlcoholLevel</strong> is in <strong>milliliters</strong>. If you receive a worker who&rsquo;s <strong>handsShaking</strong> property is set to <strong>true</strong> it means he needs to intake some alcohol in order to be able to work correctly. The required amount is 0.1ml per <strong>kilogram</strong> per year of <strong>experience</strong>. The required amount must be <strong>added</strong> to the <strong>existing amount</strong>. Once the alcohol is administered, change the <strong>handsShaking</strong> property to <strong>false</strong>.</p>
<p>Workers whose hands aren&rsquo;t shaking should <strong>not</strong> be modified in any way. Return them as they were.</p>
<h3>Input</h3>
<p>Your function will receive a valid <strong>object</strong> as <strong>parameter</strong>.</p>
<h3>Output</h3>
<p>Return the <strong>same object</strong> that was passed in, <strong>modified</strong> as necessary.</p>
<h3>Examples</h3>
<table width="1361">
<tbody>
<tr>
<td width="680">
<p>Input</p>
</td>
<td width="680">
<p>Output</p>
</td>
</tr>
<tr>
<td width="680">
<p>{ weight: 80,</p>
<p>&nbsp; experience: 1,</p>
<p>&nbsp; bloodAlcoholLevel: 0,</p>
<p>&nbsp; handsShaking: true }</p>
</td>
<td width="680">
<p>{ weight: 80,</p>
<p>&nbsp; experience: 1,</p>
<p>&nbsp; bloodAlcoholLevel: 8,</p>
<p>&nbsp; handsShaking: false }</p>
</td>
</tr>
<tr>
<td width="680">
<p>{ weight: 120,</p>
<p>&nbsp; experience: 20,</p>
<p>&nbsp; bloodAlcoholLevel: 200,</p>
<p>&nbsp; handsShaking: true }</p>
</td>
<td width="680">
<p>{ weight: 120,</p>
<p>&nbsp; experience: 20,</p>
<p>&nbsp; bloodAlcoholLevel: 440,</p>
<p>&nbsp; handsShaking: false }</p>
</td>
</tr>
<tr>
<td width="680">
<p>{ weight: 95,</p>
<p>&nbsp; experience: 3,</p>
<p>&nbsp; bloodAlcoholLevel: 0,</p>
<p>&nbsp; handsShaking: false }</p>
</td>
<td width="680">
<p>{ weight: 95,</p>
<p>&nbsp; experience: 3,</p>
<p>&nbsp; bloodAlcoholLevel: 0,</p>
<p>&nbsp; handsShaking: false }</p>
</td>
</tr>
</tbody>
</table>
<h2>3.&nbsp;&nbsp; Car Factory</h2>
<p>Write a JS program that assembles a car by <strong>given requirements</strong> out of <strong>existing</strong> <strong>components</strong>. The client will place an order in the form of an <strong>object describing</strong> the car. You need to <strong>determine</strong> which parts to use to fulfil the client&rsquo;s order. You have the following parts in storage:</p>
<p>An <strong>engine</strong> has <strong>power</strong> (given in horsepower) and <strong>volume</strong> (given in cubic centimeters). Both of these values are <strong>numbers</strong>. When selecting an engine, pick the <strong>smallest possible</strong> that still meets the requirements.</p>
<p>Small engine: { power: 90, volume: 1800 }</p>
<p>Normal engine: { power: 120, volume: 2400 }</p>
<p>Monster engine: { power: 200, volume: 3500 }</p>
<p>A <strong>carriage</strong> has a <strong>type</strong> and <strong>color</strong>. Both of these values are <strong>strings</strong>. You have two types of carriages in storage and can paint it <strong>any color</strong>.</p>
<p>Hatchback: { type: 'hatchback', color: &lt;as required&gt; }</p>
<p>Coupe: { type: 'coupe', color: &lt;as required&gt; }</p>
<p>The <strong>wheels</strong> will be represented by an <strong>array</strong> of 4 <strong>numbers</strong>, each number represents the <strong>diameter</strong> of the wheel in inches. The size can only be an <strong>odd number</strong>. Round <strong>down</strong> any requirements you receive to the nearest odd number.</p>
<h3>Input</h3>
<p>You will receive an <strong>object</strong> as an <strong>argument</strong> to your function. The format will be as follows:</p>
<p>{ model: &lt;model name&gt;,</p>
<p>&nbsp; power: &lt;minimum power&gt;,</p>
<p>&nbsp; color: &lt;color&gt;,</p>
<p>&nbsp; carriage: &lt;carriage type&gt;,</p>
<p>&nbsp; wheelsize: &lt;size&gt; }</p>
<h3>Output</h3>
<p><strong>Return</strong> the resulting car <strong>object</strong> as a result of your function. See the examples for details.</p>
<h3>Examples</h3>
<table width="1361">
<tbody>
<tr>
<td width="680">
<p>Sample input</p>
</td>
<td width="680">
<p>Output</p>
</td>
</tr>
<tr>
<td width="680">
<p>{ model: 'VW Golf II',</p>
<p>&nbsp; power: 90,</p>
<p>&nbsp; color: 'blue',</p>
<p>&nbsp; carriage: 'hatchback',</p>
<p>&nbsp; wheelsize: 14 }</p>
</td>
<td width="680">
<p>{ model: 'VW Golf II',</p>
<p>&nbsp; engine: { power: 90,</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; volume: 1800 },</p>
<p>&nbsp; carriage: { type: 'hatchback',</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; color: 'blue' },</p>
<p>&nbsp; wheels: [13, 13, 13, 13] }</p>
</td>
</tr>
<tr>
<td width="680">
<p>{ model: 'Opel Vectra',</p>
<p>&nbsp; power: 110,</p>
<p>&nbsp; color: 'grey',</p>
<p>&nbsp; carriage: 'coupe',</p>
<p>&nbsp; wheelsize: 17 }</p>
</td>
<td width="680">
<p>{ model: 'Opel Vectra',</p>
<p>&nbsp; engine: { power: 120,</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; volume: 2400 },</p>
<p>&nbsp; carriage: { type: 'coupe',</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; color: 'grey' },</p>
<p>&nbsp; wheels: [17, 17, 17, 17] }</p>
</td>
</tr>
</tbody>
</table>
<h2>4.&nbsp;&nbsp; Extensible object</h2>
<p>Create an object that can <strong>clone</strong> the <strong>functionality</strong> of another object into itself. Implement an extend(template) function that would copy all of the properties of <strong>template</strong> to the parent object and if the property is a function, add it to the object&rsquo;s <strong>prototype</strong> instead.</p>
<h3>Input / Output</h3>
<p>Your code should <strong>return</strong> the extensible <strong>object instance</strong>. The extend() function of your object will receive a valid object as <strong>input parameter</strong>, and has <strong>no</strong> output.</p>
<h3>Examples</h3>
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
<p>myObj: {</p>
<p>&nbsp; __proto__: {}</p>
<p>&nbsp; extend: function () {&hellip;}</p>
<p>}</p>
</td>
<td rowspan="3" width="680">
<p>myObj: {</p>
<p>&nbsp; __proto__: {</p>
<p>&nbsp;&nbsp;&nbsp; extensionMethod: function () {&hellip;}</p>
<p>&nbsp; },</p>
<p>&nbsp; extend: function () {&hellip;},</p>
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
<p>Note that <strong>__proto__</strong> is a hidden property, representing the object&rsquo;s <strong>prototype</strong> &ndash; depending on your test environment, you may not have access to it directly, but you can use other functions to do that.</p>
<h3>Hints</h3>
<p>To gain access to the prototype of an instance, use the <strong>Object.getPrototypeOf()</strong> function. To make a function shared between all instances, it&rsquo;ll have to be attached to the prototype instead of the instance.</p>
<h2>5.&nbsp;&nbsp; String extension</h2>
<p><strong>Extend</strong> the build-in String object with additional functionality. Implement the following functions:</p>
<ul>
<li>ensureStart(str) &ndash; append <strong>str</strong> to the beginning of a string, <strong>only</strong> if it&rsquo;s <strong>not</strong> already present</li>
<li>ensureEnd(str) &ndash; append <strong>str</strong> to the end of a string, <strong>only</strong> if it&rsquo;s <strong>not</strong> already present</li>
<li>isEmpty() &ndash; return <strong>true</strong> if the string is <strong>empty</strong>, <strong>false</strong> otherwise</li>
<li>truncate(n) &ndash; truncates the string to <strong>n</strong> characters by <strong>removing words</strong> and appends an ellipsis (three periods) to the end. If a string is less than <strong>n</strong> characters long, return the <strong>same string</strong>. If it is longer, split the string where a <strong>space</strong> occurs and append an ellipsis to it so that the <strong>total length</strong> is less than or equal to <strong>n</strong>. If <strong>no space</strong> occurs anywhere in the string, return <strong>n &ndash; 3</strong> characters and an ellipsis. If <strong>n </strong>is less than 4, return <strong>n</strong> amount of periods.</li>
<li>format(string, &hellip;params) &ndash; static method to replace placeholders with parameters. A placeholder is a number surrounded by curly braces. If parameter index cannot be found for a certain placeholder, do not modify it. Note static methods are attached to the <strong>String object</strong> instead of it&rsquo;s prototype. See the examples for more info.</li>
</ul>
<p>Note strings are <strong>immutable</strong>, so your functions will return new strings as a result.</p>
<h3>Input / Output</h3>
<p>Your <strong>main code</strong> should be structured as an <strong>IIFE</strong> <strong>without</strong> <strong>input or output</strong> &ndash; it should <strong>modify</strong> the existing <strong>String</strong> <strong>prototype</strong> instead.</p>
<p>Input and output of the <strong>extension functions</strong> should be as described above.</p>
<h3>Examples</h3>
<table width="1361">
<tbody>
<tr>
<td width="643">
<p>Sample input</p>
</td>
<td width="718">
<p>Value of <em>str</em></p>
</td>
</tr>
<tr>
<td width="643">
<p>let str = 'my string'</p>
<p>str = str.ensureStart('my')</p>
<p>str = str.ensureStart('hello ')</p>
<p>str = str.truncate(16)</p>
<p>str = str.truncate(14)</p>
<p>str = str.truncate(8)</p>
<p>str = str.truncate(4)</p>
<p>str = str.truncate(2)</p>
<p>str = String.format('The {0} {1} fox',</p>
<p>&nbsp; 'quick', 'brown');</p>
<p>str = String.format('jumps {0} {1}',</p>
<p>&nbsp; 'dog');</p>
</td>
<td width="718">
<p>&nbsp;</p>
<p>'my string' &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;// 'my' already present</p>
<p>'hello my string'</p>
<p>'hello my string' // length is 15</p>
<p>'hello my...'&nbsp;&nbsp;&nbsp;&nbsp; // length is 11</p>
<p>'hello...'</p>
<p>'h...'</p>
<p>'..'</p>
<p>&nbsp;</p>
<p>'The quick brown fox'</p>
<p>&nbsp;</p>
<p>'jumps dog {1}'&nbsp;&nbsp; // no parameter at 1</p>
</td>
</tr>
</tbody>
</table>
<h2>6.&nbsp;&nbsp; *Sorted List</h2>
<p>Implement a <strong>collection</strong>, which keeps a list of numbers, sorted in <strong>ascending order</strong>. It must support the following functionality:</p>
<ul>
<li>add(elemenent) &ndash; adds a new element to the collection</li>
<li>remove(index) &ndash; removes the element at position <strong>index</strong></li>
<li>get(index) &ndash; returns the value of the element at position <strong>index</strong></li>
<li>size &ndash; number of elements stored in the collection</li>
</ul>
<p>The <strong>correct order</strong> of the element must be kept <strong>at all times</strong>, regardless of which operation is called. <strong>Removing</strong> and <strong>retrieving</strong> elements <strong>shouldn&rsquo;t</strong> work if the provided index points <strong>outside the length</strong> of the collection (either throw an error or do nothing). Note the <strong>size</strong> of the collection is <strong>not</strong> a function. Write your code such that the first function in your solution <strong>returns an instance</strong> of your Sorted List.</p>
<h3>Input / Output</h3>
<p>All function that expect <strong>input</strong> as <strong>parameters</strong> will receive valid data. Any result expected from a function should be <strong>returned</strong> as it&rsquo;s result. Your <strong>main function</strong> should <strong>return</strong> an <strong>object</strong> <strong>instance</strong> with the required functionality as it&rsquo;s result.</p>
<h2>7.&nbsp;&nbsp; DOM Traversal</h2>
<p>Write a program that recursively <strong>traverses</strong> all child nodes of an HTML element and <strong>highlights</strong> a path to the <strong>deepest node</strong>. Your script will be placed inside an HTML page and a <strong>selector</strong> will be passed to it. Starting from a given node and searching downwards, once the node with the deepest nesting is found, add the class highlight to it to change its appearance. Add the same class to <strong>all parent nodes</strong> all the way to the <strong>selector</strong>. If two elements have the same depth, highlight the <strong>first encountered</strong>.</p>
<h3>Input</h3>
<p>Your function will be placed inside an HTML document and a <strong>selector</strong> to an HTML element will be passed to it.</p>
<h3>Output</h3>
<p>There is no output, your program should <strong>modify</strong> the HTML instead.</p>
<h3>Example</h3>
<p>Use the provided <a href="https://judge.softuni.bg/Contests/Practice/DownloadResource/1671">HTML skeleton</a> to test your code. Note you will need to download and include jQuery manually, if you want to use it in your local tests. You may find it here: <a href="http://jquery.com/download/">http://jquery.com/download/</a></p>
<h2>8.&nbsp;&nbsp; * Bug Tracker</h2>
<p>Create a JS program for managing bug reports. It must perform as a self-contained module with exposed functionality. Whenever a new element is added, deleted or changed with a command, the HTML should be updated automatically. A bug report has the following structure:</p>
<p>{ ID: Number,</p>
<p>&nbsp; author: String,</p>
<p>&nbsp; description: String,</p>
<p>&nbsp; reproducible: Boolean,</p>
<p>&nbsp; severity: Number,</p>
<p>&nbsp; status: String }</p>
<p>The <strong>ID</strong> of each report has to be a <strong>unique</strong> number, starting from <strong>zero</strong> and increasing <strong>sequentially</strong>. The module needs to implement the following <strong>functions</strong>:</p>
<p>report(author, description, reproducible, severity) &ndash; <strong>create</strong> a new bug report and store it. The <strong>ID</strong> is assigned automatically to the next available number and the <strong>status</strong> defaults to <strong>'Open'</strong></p>
<p>setStatus(id, newStatus) &ndash; change the status of a bug registered in the system to <strong>newStatus</strong> by given <strong>ID</strong></p>
<p>remove(id) &ndash; delete a bug report by given <strong>ID</strong></p>
<p>sort(method) &ndash; change the order in which bug reports are displayed on the webpage. The <strong>method</strong> argument is a string and can be either <strong>'author'</strong>, <strong>'severity'</strong> or <strong>'ID'</strong>. Always sort in ascending order (default behavior for alphabetical sort). The default sorting method is by <strong>'ID'</strong>.</p>
<p>output(selector) &ndash; set the HTML element inside which the result is to be displayed to <strong>selector</strong></p>
<p>Use the following structure for each HTML report:</p>
<table width="1329">
<tbody>
<tr>
<td width="103">
<p>HTML</p>
</td>
</tr>
<tr>
<td width="103">
<p>&lt;div id="report_${ID}" class="report"&gt;</p>
<p>&nbsp; &lt;div class="body"&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;p&gt;${description}&lt;/p&gt;</p>
<p>&nbsp; &lt;/div&gt;</p>
<p>&nbsp; &lt;div class="title"&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;span class="author"&gt;Submitted by: ${author}&lt;/span&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;span class="status"&gt;${status} | ${severity}&lt;/span&gt;</p>
<p>&nbsp; &lt;/div&gt;</p>
<p>&lt;/div&gt;</p>
</td>
</tr>
</tbody>
</table>
<p>Use the provided <a href="https://judge.softuni.bg/Contests/Practice/DownloadResource/1681">HTML skeleton</a> to test your solution locally. Note that you will have to manually add any scripts you wish to use for testing, including jQuery.</p>
<h3>Input</h3>
<p>Input will be passed to each applicable function as <strong>parameters</strong> in the correct format.</p>
<h3>Output</h3>
<p>Your solution must <strong>expose a module</strong> with all required functions bundled in it (<strong>return</strong> it as a result of your main function). The <strong>HTML</strong> should be <strong>modified</strong> as specified.</p>