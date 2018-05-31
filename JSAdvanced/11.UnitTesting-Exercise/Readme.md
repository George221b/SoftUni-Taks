<h1>Exercises: Unit Testing and Error Handling</h1>
<p>Problems for exercises and homework for the <a href="https://softuni.bg/courses/javascript-advanced">&ldquo;JavaScript Advanced&rdquo; course @ SoftUni</a>. Submit your solutions in the SoftUni judge system at <a href="https://judge.softuni.bg/Contests/335/">https://judge.softuni.bg/Contests/335/</a>.</p>
<h1>Error Handling</h1>
<h2>1.&nbsp;&nbsp; Request Validator</h2>
<p>Write a JS function that validates an HTTP request object. The object has the properties method, uri, version and message. Your function must receive the object as a parameter and verify that each property meets the following requirements:</p>
<ul>
<li>method &ndash; can be <strong>GET</strong>, <strong>POST</strong>, <strong>DELETE</strong> or <strong>CONNECT</strong></li>
<li>uri &ndash; must be a valid resource address or an asterisk (*); a resource address is a combination of alphanumeric characters and periods; all letters are Latin; the URI <strong>cannot</strong> be an empty string</li>
<li>version &ndash; can be <strong>HTTP/0.9</strong>, <strong>HTTP/1.0</strong>, <strong>HTTP/1.1</strong> or <strong>HTTP/2.0</strong> supplied as a string</li>
<li>message &ndash; may contain <strong>any number</strong> of non-special characters; special characters are &lt;, &gt;, \, &amp;, ', "</li>
</ul>
<p>If a request is valid, return it unchanged. If any part fails the check, throw an <strong>Error</strong> with message "<strong>Invalid request header: Invalid {Method/URI/Version/Message}</strong>". Replace the part in curly braces with the relevant word. Note that some of the <strong>properties may be missing</strong>, in which case the request is invalid. Check the properties in the order in which they are listed here. If more than one property is invalid, throw an error for the first encountered.</p>
<h3>Input / Output</h3>
<p>Your function will receive an object as a parameter. As output, <strong>return</strong> the same object or throw an <strong>Error</strong> as described above.</p>
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
<p>validateRequest({</p>
<p>&nbsp; method: 'GET',</p>
<p>&nbsp; uri: 'svn.public.catalog',</p>
<p>&nbsp; version: 'HTTP/1.1',</p>
<p>&nbsp; message: ''</p>
<p>});</p>
</td>
<td width="680">
<p>{</p>
<p>&nbsp; method: 'GET',</p>
<p>&nbsp; uri: 'svn.public.catalog',</p>
<p>&nbsp; version: 'HTTP/1.1',</p>
<p>&nbsp; message: ''</p>
<p>}</p>
</td>
</tr>
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
<p>validateRequest({</p>
<p>&nbsp; method: 'OPTIONS',</p>
<p>&nbsp; uri: 'git.master',</p>
<p>&nbsp; version: 'HTTP/1.1',</p>
<p>&nbsp; message: '-recursive'</p>
<p>});</p>
</td>
<td width="680">
<p>Invalid request header: Invalid Method</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
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
<p>validateRequest({</p>
<p>&nbsp; method: 'POST',</p>
<p>&nbsp; uri: 'home.bash',</p>
<p>&nbsp; message: 'rm -rf /*'</p>
<p>});</p>
</td>
<td width="680">
<p>Invalid request header: Invalid Version</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>Since validating some of the fields may require the use of <strong>RegExp</strong>, you can check your expressions using the following samples:</p>
<table width="1361">
<tbody>
<tr>
<td colspan="2" width="1361">
<p>URI</p>
</td>
</tr>
<tr>
<td width="680">
<p>Valid</p>
</td>
<td width="680">
<p>Invalid</p>
</td>
</tr>
<tr>
<td width="680">
<p>svn.public.catalog</p>
<p>git.master</p>
<p>version1.0</p>
<p>for..of</p>
<p>.babelrc</p>
<p>c</p>
</td>
<td width="680">
<p>%appdata%</p>
<p>apt-get</p>
<p>&nbsp;</p>
<p>home$</p>
<p>define apps</p>
<p>"documents"</p>
</td>
</tr>
</tbody>
</table>
<ul>
<li>Note that the URI <strong>cannot</strong> be an empty string.</li>
</ul>
<table width="1361">
<tbody>
<tr>
<td colspan="2" width="1361">
<p>Message</p>
</td>
</tr>
<tr>
<td width="680">
<p>Valid</p>
</td>
<td width="680">
<p>Invalid</p>
</td>
</tr>
<tr>
<td width="680">
<p>-recursive</p>
<p>rm -rf /*</p>
<p>hello world</p>
<p>https://svn.myservice.com/downloads/</p>
<p>%root%</p>
</td>
<td width="680">
<p>&lt;script&gt;alert("xss vulnerable")&lt;/script&gt;</p>
<p>\r\n</p>
<p>&amp;copy;</p>
<p>"value"</p>
<p>'; DROP TABLE</p>
</td>
</tr>
</tbody>
</table>
<ul>
<li>Note that the message <strong>may</strong> be an empty string, but the property must still be present.</li>
</ul>
<p>&nbsp;</p>
<p>&nbsp;</p>
<h1>Unit Testing</h1>
<p>The Unit Tests with Sinon and Mocha strategy gives you access to the following libraries to help you test your code - Mocha, Sinon, Chai, Sinon-Chai and jQuery.</p>
<p>You are required to <strong>only submit the unit tests</strong> for the object/function you are testing. The strategy provides access to Chai's <strong>expect</strong>, <strong>assert</strong> and <strong>should</strong> methods and jQuery.</p>
<h3>Example Submission</h3>
<h2>2.&nbsp;&nbsp; Even or Odd</h2>
<p>You need to write <strong>unit</strong> <strong>tests</strong> for a function isOddOrEven that checks whether a passed in <strong>string</strong> has <strong>even</strong> or <strong>odd</strong> <strong>length</strong>. The function has the following functionality:</p>
<ul>
<li>isOddOrEven(string) - A function that accepts a string and determines if the string has <strong>even</strong> or <strong>odd</strong> <strong>length</strong>.
<ul>
<li>If the passed parameter is <strong>not a string</strong> return <strong>undefined</strong>.</li>
<li>If the parameter is a <strong>string</strong> - return either <strong>"even"</strong> or <strong>"odd"</strong> based on the string's length.</li>
</ul>
</li>
</ul>
<h3>JS Code</h3>
<p>To ease you in the process, you are provided with an implementation which meets all of the specification requirements for the isOddOrEven function:</p>
<table width="1329">
<tbody>
<tr>
<td width="1329">
<p>isOdd.js</p>
</td>
</tr>
<tr>
<td width="1329">
<p><strong>function </strong><em>isOddOrEven</em>(string) {<br /> &nbsp;&nbsp;&nbsp; <strong>if </strong>(<strong>typeof</strong>(string) !== <strong>'string'</strong>) {<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>return </strong><strong>undefined</strong>;<br /> &nbsp;&nbsp;&nbsp; }<br /> &nbsp;&nbsp;&nbsp; <strong>if </strong>(string.<strong>length </strong>% 2 === 0) {<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>return </strong><strong>"even"</strong>;<br /> &nbsp;&nbsp;&nbsp; }<br /> <br /> &nbsp;&nbsp;&nbsp; <strong>return </strong><strong>"odd"</strong>;<br /> }</p>
</td>
</tr>
</tbody>
</table>
<p>Submit in the judge your code containing Mocha tests testing the above functionality.</p>
<p>Your tests will be supplied a function named "isOddOrEven" which contains the above mentioned logic, all test cases you write should reference this function. You can check the example at the beginning of this document to grasp the syntax.</p>
<h3>Hints</h3>
<p>We can clearly see there are 3 outcomes of the function:</p>
<ul>
<li>Returning <strong>undefined</strong>.</li>
<li>Returning <strong>"even"</strong>.</li>
<li>Returning<strong> "odd"</strong>.</li>
</ul>
<p>We can write one or two tests passing things other than string to the function and expecting it to return <strong>undefined</strong>.</p>
<p>After we've checked the validation it's time to check whether the function works correctly with proper arguments. We can write a test for each of the cases:</p>
<p>One where we pass a string with <strong>even</strong> length:</p>
<p>&nbsp;And one where we pass a string with an <strong>odd</strong> length:</p>
<p>Finally we can make an extra test passing multiple different strings in a row to ensure the function is consistent:</p>
<p>Our code is now ready to be submitted to the Judge System.</p>
<h2>3.&nbsp;&nbsp; Char Lookup</h2>
<p>You are tasked with writing <strong>unit tests</strong> for a simplistic function that <strong>retrieves a character </strong>(a string containing only 1 symbol in JS) at a given <strong>index</strong> from a passed in <strong>string</strong>.</p>
<p>You are supplied a function named <strong>lookupChar</strong>, which should have the following functionality:</p>
<ul>
<li>lookupChar(string, index) - A function that accepts a string - the <strong>string</strong> in which we&rsquo;ll search and a number - the <strong>index</strong> of the char we want to lookup:
<ul>
<li>If the first parameter is not a string or the second parameter is not an integer - return <strong>undefined</strong>.</li>
<li>If both parameters are of the correct type, but the value of the index is incorrect (bigger than or equal to the string length or a negative number) - return the text <strong>"Incorrect index"</strong>.</li>
<li>If both parameters have correct types and values - return the <strong>character at the specified index</strong> in the string.</li>
</ul>
</li>
</ul>
<h3>JS Code</h3>
<p>To ease you in the process, you are provided with an implementation which meets all of the specification requirements for the lookupChar function:</p>
<table width="1329">
<tbody>
<tr>
<td width="1329">
<p>lookupChar.js</p>
</td>
</tr>
<tr>
<td width="1329">
<p><strong>function </strong><em>lookupChar</em>(string, index) {<br /> &nbsp;&nbsp;&nbsp; <strong>if </strong>(<strong>typeof</strong>(string) !== <strong>'string' </strong>|| !Number.isInteger(index)) {<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>return </strong><strong>undefined</strong>;<br /> &nbsp;&nbsp;&nbsp; }<br /> &nbsp;&nbsp;&nbsp; <strong>if </strong>(string.<strong>length </strong>&lt;= index || index &lt; 0) {<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>return </strong><strong>"Incorrect index"</strong>;<br /> &nbsp;&nbsp;&nbsp; }<br /> <br /> &nbsp;&nbsp;&nbsp; <strong>return </strong>string.charAt(index);<br /> }</p>
</td>
</tr>
</tbody>
</table>
<p>Your tests will be supplied a function named <strong>"</strong>lookupChar<strong>"</strong> which contains the above mentioned logic, all test cases you write should reference this function. Submit in the judge your code containing Mocha tests testing the above functionality.</p>
<h3>Hints</h3>
<p>Writing tests is all about thinking, a good first step in testing a method is usually to determine all exit conditions (all ways in which the method can end its execution - <strong>return </strong>statements<strong>, throw </strong>statements or if none of the previous are present <strong>simply running to the end</strong>). Reading through the specification or taking a look at the implementation we can easily determine <strong>3 main exit conditions</strong> - returning <strong>undefined, </strong>returning an<strong> empty string</strong> or <strong>returning the char</strong> at the specified index.</p>
<p>Now that we have our exit conditions we should start checking in what situations we can reach them. We&rsquo;ll start with returning&nbsp; <strong>undefined</strong>. Reading the specification we can see that if any of the parameters are of the incorrect type we need to return <strong>undefined</strong>. Having two input parameters we easily have our first 2 tests.</p>
<p>It may look like these two tests are enough to cover the first exit condition, however taking a closer look at the implementation, we see that the check uses Number.isInteger() instead of typeof(index === number) to check the index. While typeof would protect us from getting passed an index that is a non-number, it won&rsquo;t protect us from being passed a <strong>floating point number</strong>. The specification says that <strong>index</strong> needs to be an <strong>integer</strong> (so it could be used for getting the char at the index), since floating point numbers won&rsquo;t work as indexes, we need to make sure that the passed in index is not a floating point number.</p>
<p>Having added the extra test we have now covered the first exit condition, moving on we go to the next one - returning <strong>empty string</strong>. Checking the specification again we can see two distinct cases that we should check for - getting passed an index that is a negative number or getting passed an index which is outside of the bounds of the string.</p>
<p>Normally this would be enough to cover this condition, however the situation where the <strong>index</strong> passed is <strong>equal to the string length</strong> (known as an edge case) can be easily missed when writing the code, so it&rsquo;s a good idea to test for it too.</p>
<p>Having cleared all the validation checks it&rsquo;s time for the last exit condition - <strong>returning a correct result</strong>, when checking results there are usually a number of things to check depending on the returned value and specification of the function. In our situation we are returning a <strong>char</strong> so a simple check for the returned value will be enough, however a single test for the correct return value is akin to guessing.</p>
<p>&nbsp;In a situation where there are limited correct results (for example a method which returns true or false) getting the correct value in one test does not guarantee the correctness of the method, even if the method did not function correctly there would still be a 50-50 chance of us receiving the correct result. To counteract this problem we usually create more than one test to check for the correct result. More tests is always better, but in most situations a few tests with different input parameters and different expected return values would be enough to cover the function.</p>
<p><br /> With these last two tests we have covered the lookupChar function. Our code is now ready to be submitted to the Judge System.</p>
<h2>4.&nbsp;&nbsp; Math Enforcer</h2>
<p>Your task is to test a variable named <strong>mathEnforcer</strong>, which represents an object that should have the following functionality:</p>
<ul>
<li>addFive(num) - A function that accepts a single parameter:
<ul>
<li>If the parameter is not a number, the funtion should return <strong>undefined</strong>.</li>
<li>If the parameter is a number, <strong>add 5</strong> to it, and return the result.</li>
</ul>
</li>
<li>subtractTen(num) - A function that accepts a single parameter:
<ul>
<li>If the parameter is not a number, the function should return <strong>undefined</strong>.</li>
<li>If the parameter is a number, <strong>subtract 10</strong> from it, and return the result.</li>
</ul>
</li>
<li>sum(num1, num2) - A function that should accepts two parameters:
<ul>
<li>If any of the 2 parameters is not a number, the function should return <strong>undefined</strong>.</li>
<li>If both parameters are numbers, the function should <strong>return their</strong> <strong>sum</strong>.</li>
</ul>
</li>
</ul>
<h3>JS Code</h3>
<p>To ease you in the process, you are provided with an implementation which meets all of the specification requirements for the mathEnforcer object:</p>
<table width="1329">
<tbody>
<tr>
<td width="1329">
<p>mathEnforcer.js</p>
</td>
</tr>
<tr>
<td width="1329">
<p><strong>let </strong>mathEnforcer = {<br /> &nbsp;&nbsp;&nbsp; addFive: <strong>function </strong>(num) {<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>if </strong>(<strong>typeof</strong>(num) !== <strong>'number'</strong>) {<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>return </strong><strong>undefined</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>return </strong>num + 5;<br /> &nbsp;&nbsp;&nbsp; },<br /> &nbsp;&nbsp;&nbsp; subtractTen: <strong>function </strong>(num) {<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>if </strong>(<strong>typeof</strong>(num) !== <strong>'number'</strong>) {<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>return </strong><strong>undefined</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>return </strong>num - 10;<br /> &nbsp;&nbsp;&nbsp; },<br /> &nbsp;&nbsp;&nbsp; sum: <strong>function </strong>(num1, num2) {<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>if </strong>(<strong>typeof</strong>(num1) !== <strong>'number' </strong>|| <strong>typeof</strong>(num2) !== <strong>'number'</strong>) {<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>return </strong><strong>undefined</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>return </strong>num1 + num2;<br /> &nbsp;&nbsp;&nbsp; }<br /> };</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>The methods should function correctly for <strong>positive</strong>, <strong>negative</strong> and <strong>floating point</strong> numbers. In case of <strong>floating point</strong> numbers the result should be considered correct if it is <strong>within 0.01</strong> of the correct value. Submit in the judge your code containing Mocha tests testing the above functionality.</p>
<h3>Screenshots</h3>
<p>When testing a more complex object write a nested describe for each function:</p>
<p>Your tests will be supplied a variable named <strong>"mathEnforcer"</strong> which contains the above mentioned logic, all test cases you write should reference this variable. Submit in the judge your code containing Mocha tests testing the above functionality.</p>
<h3>Hints</h3>
<ul>
<li>Test how the program behaves when passing in <strong>negative</strong></li>
<li>Test the program with floating point numbers (use Chai&rsquo;s <strong>closeTo</strong> method to compare floating point numbers).</li>
</ul>
<h2>5.&nbsp;&nbsp; Shared Object</h2>
<p>You are tasked to test a <strong>sharedObject</strong> responsible for keeping a valid state between a JS object and two HTML textboxes. The two textboxes will always have <strong>id</strong>s name for the <strong>name textbox</strong> and income for the <strong>income textbox</strong>, and will always start with<strong> empty strings </strong>as values. The sharedObject should have the following functionality:</p>
<ul>
<li>name - a property holding a string, starts with value null by default.</li>
<li>income - a property holding a number, starts with value null by default.</li>
<li>changeName(name) - In case the passed in parameter is an<strong> empty string</strong> -<strong> no changes should be made</strong>, alternatively the sharedObject's name property and the<strong> name textbox's value </strong>should be set to the passed in parameter.</li>
<li>changeIncome(income) - In case the passed in parameter is <strong>not a positive integer</strong> - <strong>no changes should be made</strong>, alternatively the sharedObject's income property and the<strong> income textbox's value </strong>should be set to the passed in parameter.</li>
<li>updateName() - In case the name textbox's value is an<strong> empty string</strong> - <strong>no changes should be made</strong>, alternatively the name property of the sharedObject should be set to the <strong>value </strong>of the<strong> name textbox</strong>.</li>
<li>updateIncome() - In case the income textbox's value <strong>cannot be parsed</strong> to a <strong>positive integer</strong> - <strong>no changes should be made</strong>, alternatively the income property of the sharedObject should be set to the <strong>value </strong>of the<strong> income textbox</strong>.</li>
</ul>
<h3>HTML and JS Code</h3>
<p>To ease you in the process, you are provided with an HTML template for testing:</p>
<table width="1329">
<tbody>
<tr>
<td width="1329">
<p>shared-object.html</p>
</td>
</tr>
<tr>
<td width="1329">
<p>&lt;!DOCTYPE <strong>html</strong>&gt;<br /> &lt;<strong>html </strong><strong>lang=</strong><strong>"en"</strong>&gt;<br /> &lt;<strong>head</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>meta </strong><strong>charset=</strong><strong>"UTF-8"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>title</strong>&gt;Shared Object&lt;/<strong>title</strong>&gt;<br /> &lt;/<strong>head</strong>&gt;<br /> &lt;<strong>body</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>div </strong><strong>id=</strong><strong>"wrapper"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>input </strong><strong>type=</strong><strong>"text" </strong><strong>id=</strong><strong>"name"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>input </strong><strong>type=</strong><strong>"text" </strong><strong>id=</strong><strong>"income"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;/<strong>div</strong>&gt;<br /> &lt;/<strong>body</strong>&gt;<br /> &lt;/<strong>html</strong>&gt;</p>
</td>
</tr>
</tbody>
</table>
<p>And an implementation which meets all of the specification requirements for the sharedObject:</p>
<table width="1329">
<tbody>
<tr>
<td width="1329">
<p>shared-object.js</p>
</td>
</tr>
<tr>
<td width="1329">
<p><strong>let </strong><strong><em>sharedObject </em></strong>= {<br /> &nbsp;&nbsp;&nbsp; <strong>name</strong>: <strong>null</strong>,<br /> &nbsp;&nbsp;&nbsp; <strong>income</strong>: <strong>null</strong>,<br /> &nbsp;&nbsp;&nbsp; changeName: <strong>function </strong>(name) {<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>if </strong>(name.<strong>length </strong>=== 0) {<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>return</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>this</strong>.<strong>name </strong>= name;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>let </strong>newName = <strong>$</strong>(<strong>'#name'</strong>);<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; newName.val(<strong>this</strong>.<strong>name</strong>);<br /> &nbsp;&nbsp;&nbsp; },<br /> &nbsp;&nbsp;&nbsp; changeIncome: <strong>function </strong>(income) {<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>if </strong>(!Number.isInteger(income) || income &lt;= 0) {<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>return</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>this</strong>.<strong>income </strong>= income;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>let </strong>newIncome = <strong>$</strong>(<strong>'#income'</strong>);<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; newIncome.val(<strong>this</strong>.<strong>income</strong>);<br /> &nbsp;&nbsp;&nbsp; },<br /> &nbsp;&nbsp;&nbsp; updateName: <strong>function </strong>() {<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>let </strong>newName = <strong>$</strong>(<strong>'#name'</strong>).val();<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>if </strong>(newName.<strong>length </strong>=== 0) {<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>return</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>this</strong>.<strong>name </strong>= newName;<br /> &nbsp;&nbsp;&nbsp; },<br /> &nbsp;&nbsp;&nbsp; updateIncome: <strong>function </strong>() {<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>let </strong>newIncome = <strong>$</strong>(<strong>'#income'</strong>).val();<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>if </strong>(isNaN(newIncome) || !Number.isInteger(Number(newIncome)) || Number(newIncome) &lt;= 0) {<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>return</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>this</strong>.<strong>income </strong>= Number(newIncome);<br /> &nbsp;&nbsp;&nbsp; }<br /> };</p>
</td>
</tr>
</tbody>
</table>
<p>Your tests will be supplied a variable named <strong>"sharedObject"</strong> which contains the above mentioned logic, all test cases you write should reference this variable. Submit in the judge your code containing Mocha tests testing the above functionality.</p>
<h3>Hints</h3>
<ul>
<li>Test that the initial state of the sharedObject meets the specification (i.e. <strong>name</strong> and <strong>income</strong> start as null).</li>
<li>Test the functions with preexisting values to ensure that the old values are kept.</li>
</ul>
<h2>6.&nbsp;&nbsp; ArmageDOM</h2>
<p>Write Mocha tests to check the functionality of the following JS code:</p>
<table width="1361">
<tbody>
<tr>
<td width="1361">
<p>armagedom.js</p>
</td>
</tr>
<tr>
<td width="1361">
<p><strong>function </strong><em>nuke</em>(selector1, selector2) {<br /> &nbsp;&nbsp;&nbsp; <strong>if </strong>(selector1 === selector2) <strong>return</strong>;<br /> &nbsp;&nbsp;&nbsp; $(selector1).filter(selector2).remove();<br /> }</p>
</td>
</tr>
</tbody>
</table>
<p>Your tests will be supplied a function named 'nuke'. It needs to meet the following:</p>
<ul>
<li>Operates inside an HTML document</li>
<li>Takes two <strong>string</strong> arguments, each argument is a jQuery selector</li>
<li>Upon execution, deletes <strong>all</strong> nodes that match <strong>both</strong> selectors</li>
<li>Does nothing if <strong>either</strong> selector is invalid or omitted</li>
<li>Does nothing if the two selectors are the same</li>
</ul>
<p>When testing, note that if the selector is an ID, jQuery will always return only the first element that is a match, as opposed to a collection of all elements with that ID. You may use the following HTML for testing:</p>
<table width="1361">
<tbody>
<tr>
<td width="1361">
<p>armagedom.html</p>
</td>
</tr>
<tr>
<td width="1361">
<p>&lt;!DOCTYPE <strong>html</strong>&gt;<br /> &lt;<strong>html </strong><strong>lang=</strong><strong>"en"</strong>&gt;<br /> &lt;<strong>head</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>meta </strong><strong>charset=</strong><strong>"UTF-8"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>title</strong>&gt;ArmageDOM&lt;/<strong>title</strong>&gt;<br /> &lt;/<strong>head</strong>&gt;<br /> &lt;<strong>body</strong>&gt;<br /> &lt;<strong>div </strong><strong>id=</strong><strong>"target"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>div </strong><strong>class=</strong><strong>"nested target"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>p</strong>&gt;This is some text&lt;/<strong>p</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;/<strong>div</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>div </strong><strong>class=</strong><strong>"target"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>p</strong>&gt;Empty div&lt;/<strong>p</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;/<strong>div</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>div </strong><strong>class=</strong><strong>"inside"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>span </strong><strong>class=</strong><strong>"nested"</strong>&gt;Some more text&lt;/<strong>span</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>span </strong><strong>class=</strong><strong>"target"</strong>&gt;Some more text&lt;/<strong>span</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;/<strong>div</strong>&gt;<br /> &lt;/<strong>div</strong>&gt;<br /> &lt;/<strong>body</strong>&gt;<br /> &lt;/<strong>html</strong>&gt;</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>You need to manually include the HTML you want to test with in a beforeEach() Mocha statement.</p>