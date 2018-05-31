<h1>Lab: Object Composition</h1>
<p>Problems for exercises and homework for the <a href="https://softuni.bg/courses/javascript-advanced">&ldquo;JavaScript Advanced&rdquo; course @ SoftUni</a>. Submit your solutions in the SoftUni judge system at <a href="https://judge.softuni.bg/Contests/334">https://judge.softuni.bg/Contests/334</a>.</p>
<h2>1.&nbsp;&nbsp; Order Rectangles</h2>
<p>You will be passed a few pairs of <strong>widths</strong> and <strong>heights</strong> of rectangles, create <strong>objects</strong> to represent the rectangles. The objects should additionally have two functions area - that returns the area of the rectangle and compareTo - that compares the current rectangle with another and produces a number&nbsp; signifying if the current rectangle is <strong>smaller</strong> (negative number), <strong>equal</strong> (0) or <strong>larger</strong>(positive number) than the other rectangle.</p>
<h3>Input</h3>
<p>The input will come as an array of arrays - every nested array will contain exactly 2 numbers the width and the height of the rectangle.</p>
<h3>Output</h3>
<p>The output must consist of an array of <strong>rectangles</strong> (objects) sorted by their area in <strong>descending</strong> order as a <strong>first</strong> criteria and by their width in <strong>descending</strong> order as a <strong>second</strong> criteria.&nbsp;</p>
<h3>Examples</h3>
<table width="1400">
<tbody>
<tr>
<td width="416">
<p>Input</p>
</td>
<td width="984">
<p>Output</p>
</td>
</tr>
<tr>
<td width="416">
<p>[[10,5],[5,12]]</p>
</td>
<td width="984">
<p>[{width:5, height:12, area:function(), compareTo:function(other)},</p>
<p>{width:10, height:5, area:funciton(),compareTo:function(other)}]</p>
</td>
</tr>
<tr>
<td width="416">
<p>[[10,5], [3,20], [5,12]]</p>
</td>
<td width="984">
<p>[{width:5, height:12, area:function(), compareTo:function(other)},</p>
<p>{width:3, height:20, area:funciton(),compareTo:function(other)},</p>
<p>{width:10, height:5, area:funciton(),compareTo:function(other)}]]</p>
</td>
</tr>
</tbody>
</table>
<h2>2.&nbsp;&nbsp; Fibonacci</h2>
<p>Write a JS function that when called, returns the next Fibonacci number, starting at 0, 1. Use a closure to keep the current number.</p>
<h3>Input</h3>
<p>There will be no input.</p>
<h3>Output</h3>
<p>The <strong>output</strong> must be a Fibonacci number.</p>
<h3>Examples</h3>
<table width="1391">
<tbody>
<tr>
<td width="1391">
<p>Sample exectuion</p>
</td>
</tr>
<tr>
<td width="1391">
<p>let fib = getFibonator();</p>
<p>fib(); <em>// 1</em></p>
<p>fib(); <em>// 1</em></p>
<p>fib(); <em>// 2</em></p>
<p>fib(); <em>// 3</em></p>
<p>fib(); <em>// 5</em></p>
<p>fib(); <em>// 8</em></p>
<p>fib(); <em>// 13</em></p>
</td>
</tr>
</tbody>
</table>
<h2>3.&nbsp;&nbsp; List Processor</h2>
<p>Using a closure, create an inner object to process list commands. The commands supported should be the following:</p>
<ul>
<li><strong>add</strong> <strong>&lt;string&gt;</strong> - adds the following string in an inner collection.</li>
<li><strong>remove</strong> <strong>&lt;string&gt;</strong> - removes all occurrences of the supplied <strong>&lt;string&gt;</strong> from the inner collection.</li>
<li><strong>print</strong> - prints all elements of the inner collection joined by <strong>", "</strong>.</li>
</ul>
<h3>Input</h3>
<p>The <strong>input</strong> will come as an array of strings - each string represents a <strong>command</strong> to be executed from the command execution engine.</p>
<h3>Output</h3>
<p>For every print command - you should print on the console the inner collection joined by <strong>", "</strong></p>
<h3>Examples</h3>
<table width="1400">
<tbody>
<tr>
<td width="608">
<p>Input</p>
</td>
<td width="792">
<p>Output</p>
</td>
</tr>
<tr>
<td width="608">
<p>[<strong>'add hello'</strong>, <strong>'add again'</strong>, <strong>'remove hello'</strong>, <strong>'add again'</strong>, <strong>'print'</strong>]</p>
</td>
<td width="792">
<p><strong>again,again</strong></p>
</td>
</tr>
<tr>
<td width="608">
<p>[<strong>'add pesho'</strong>, <strong>'add gosho'</strong>, <strong>'add pesho'</strong>, <strong>'remove pesho'</strong>,<strong>'print'</strong>]</p>
</td>
<td width="792">
<p>gosho</p>
</td>
</tr>
</tbody>
</table>
<h2>4.&nbsp;&nbsp; Cars</h2>
<p>Write a closure that can create and modify objects. All created objects should be <strong>kept</strong> and be accessible by <strong>name</strong>. You should support the following functionality:</p>
<ul>
<li>create &lt;name&gt; - creates an object with the supplied <strong>&lt;name&gt;</strong></li>
<li>create &lt;name&gt; inherits &lt;parentName&gt; - creates an object with the given &lt;name&gt;, that inherits from the parent object with the &lt;parentName&gt;</li>
<li>set &lt;name&gt; &lt;key&gt; &lt;value&gt; - sets the property with key equal to &lt;key&gt; to &lt;value&gt; in the object with the supplied &lt;name&gt;.</li>
<li>print &lt;name&gt; - prints the object with the supplied &lt;name&gt; in the format "&lt;key1&gt;:&lt;value1&gt;,&lt;key2&gt;:&lt;value2&gt;&hellip;" - the printing should also print all <strong>inherited properties</strong> from parent objects. Inherited properties should come after own properties.</li>
</ul>
<h3>Input</h3>
<p>The <strong>input</strong> will come as an array of strings - each string represents a <strong>command</strong> to be executed from your closure.</p>
<h3>Output</h3>
<p>For every print command - you should print on the console all properties of the object in the above mentioned format.</p>
<h3>Constraints</h3>
<ul>
<li><strong>All commands will always be valid, there will be no nonexistent or incorrect input.</strong></li>
</ul>
<h3>Examples</h3>
<table width="1400">
<tbody>
<tr>
<td width="956">
<p>Input</p>
</td>
<td width="444">
<p>Output</p>
</td>
</tr>
<tr>
<td width="956">[<strong>'create c1'</strong>,<strong>'create c2 inherit c1'</strong>,<strong>'set c1 color red'</strong>,<strong>'set c2 model new'</strong>,<strong>'print c1'</strong>,<strong>'print c2'</strong>]
<p>&nbsp;</p>
</td>
<td width="444">
<p><strong>color:red</strong></p>
<p><strong>model:new, color:red</strong></p>
<p>&nbsp;</p>
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<h2>5.&nbsp;&nbsp; Sum</h2>
<p>Create a function which returns an object that can modify the DOM. The returned object should support the following functionality:</p>
<ul>
<li>init(selector1, selector2, resultSelector) - initializes the object to work with the elements corresponding to the supplied selectors.</li>
<li>add() - <strong>adds</strong> the numerical value of the element corresponding to selector1 to the numerical value of the element corresponding to selector2 and then writes the result in the element corresponding to <strong>resultSelector</strong></li>
<li>subtract() - <strong>subtracts</strong> the numerical value of the element corresponding to selector2 from the numerical value of the element corresponding to selector1 and then writes the result in the element corresponding to resultSelector</li>
</ul>
<h3>Input</h3>
<p>There will be no input your function must only provide an object.</p>
<h3>Output</h3>
<p>Your function should return an object that meets the specified requirements.</p>
<h3>Constraints</h3>
<ul>
<li><strong>All commands will always be valid, there will be no nonexistent or incorrect input.</strong></li>
<li><strong>All selectors will point to single textbox elements.</strong></li>
</ul>
<h3>HTML</h3>
<p>You are given the following HTML for testing purposes:</p>
<table width="1400">
<tbody>
<tr>
<td width="1400">
<p>sum.html</p>
</td>
</tr>
<tr>
<td width="1400">
<p>&lt;!DOCTYPE <strong>html</strong>&gt;<br /> &lt;<strong>html </strong><strong>lang=</strong><strong>"en"</strong>&gt;<br /> &lt;<strong>head</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>meta </strong><strong>charset=</strong><strong>"UTF-8"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>title</strong>&gt;Title&lt;/<strong>title</strong>&gt;<br /> &lt;/<strong>head</strong>&gt;<br /> &lt;<strong>body</strong>&gt;<br /> &lt;<strong>input </strong><strong>type=</strong><strong>"text" </strong><strong>id=</strong><strong>"num1" </strong>/&gt;<br /> &lt;<strong>input </strong><strong>type=</strong><strong>"text" </strong><strong>id=</strong><strong>"num2" </strong>/&gt;<br /> &lt;<strong>input </strong><strong>type=</strong><strong>"text" </strong><strong>id=</strong><strong>"result" </strong><strong>readonly </strong>/&gt;<br /> &lt;<strong>br</strong>&gt;<br /> &lt;<strong>button </strong><strong>id=</strong><strong>"sumButton"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; Sum&lt;/<strong>button</strong>&gt;<br /> &lt;<strong>button </strong><strong>id=</strong><strong>"subtractButton"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; Subtract&lt;/<strong>button</strong>&gt;<br /> &lt;/<strong>body</strong>&gt;<br /> &lt;/<strong>html</strong>&gt;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>