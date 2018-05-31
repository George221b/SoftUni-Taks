<h1>JS Advanced: Exam 23 July 2017</h1>
<p>Problems for exam preparation for the <a href="https://softuni.bg/courses/javascript-advanced">&ldquo;JavaScript Advanced&rdquo; course @ SoftUni</a>. Submit your solutions in the SoftUni judge system at <a href="https://judge.softuni.bg/Contests/699/">https://judge.softuni.bg/Contests/699/</a>.</p>
<h1>Problem 1. Select and Print (Simple DOM Interaction)</h1>
<p>You are given the following <strong>HTML code</strong>:</p>
<table width="1385">
<tbody>
<tr>
<td width="1385">
<p>select-print.html</p>
</td>
</tr>
<tr>
<td width="1385">
<p>&lt;!DOCTYPE <strong>html</strong>&gt;<br /> &lt;<strong>html</strong>&gt;<br /> &lt;<strong>head</strong>&gt;<br /> &nbsp; &lt;<strong>title</strong>&gt;Select and Print&lt;/<strong>title</strong>&gt;<br /> &nbsp; &lt;<strong>style</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; <strong>select </strong>{ <strong>width</strong>: 100<strong>px </strong>}<br /> &nbsp;&nbsp;&nbsp; .<strong>block </strong>{ <strong>display</strong>: <strong>inline-block</strong>; <strong>vertical-align</strong>: <strong>top</strong>; <strong>text-align</strong>: <strong>center </strong>}<br /> &nbsp;&nbsp;&nbsp; <strong>button </strong>{ <strong>width</strong>: 60<strong>px </strong>}<br /> &nbsp;&nbsp;&nbsp; <strong>#btnRight </strong>{ <strong>display</strong>: <strong>block</strong>; <strong>margin-top</strong>: 20<strong>px </strong>}<br /> &nbsp;&nbsp;&nbsp; <strong>#btnLeft </strong>{ <strong>display</strong>: <strong>block</strong>; <strong>margin-top</strong>: 5<strong>px </strong>}<br /> &nbsp;&nbsp;&nbsp; <strong>#btnPrint </strong>{ <strong>display</strong>: <strong>block</strong>; <strong>margin-top</strong>: 5<strong>px </strong>}<br /> &nbsp; &lt;/<strong>style</strong>&gt;<br /> &nbsp; &lt;<strong>script </strong><strong>src=</strong><strong>"https://code.jquery.com/jquery-3.1.1.min.js"</strong>&gt;&lt;/<strong>script</strong>&gt;<br /> &lt;/<strong>head</strong>&gt;<br /> &lt;<strong>body</strong>&gt;<br /> &lt;<strong>div </strong><strong>class=</strong><strong>"block"</strong>&gt;<br /> &nbsp; &lt;<strong>div</strong>&gt;Available towns&lt;/<strong>div</strong>&gt;<br /> &nbsp; &lt;<strong>select </strong><strong>id=</strong><strong>"available-towns" </strong><strong>size=</strong><strong>"5"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>option</strong>&gt;Sofia&lt;/<strong>option</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>option</strong>&gt;Varna&lt;/<strong>option</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>option</strong>&gt;Pleven&lt;/<strong>option</strong>&gt;<br /> &nbsp; &lt;/<strong>select</strong>&gt;<br /> &lt;/<strong>div</strong>&gt;<br /> &lt;<strong>div </strong><strong>class=</strong><strong>"block"</strong>&gt;<br /> &nbsp; &lt;<strong>button </strong><strong>id=</strong><strong>"btnRight" </strong><strong>onclick=</strong><strong>"</strong><em>move</em>(<strong>'right'</strong>)<strong>"</strong>&gt;<strong>&amp;rightarrow;</strong>&lt;/<strong>button</strong>&gt;<br /> &nbsp; &lt;<strong>button </strong><strong>id=</strong><strong>"btnLeft" </strong><strong>onclick=</strong><strong>"</strong><em>move</em>(<strong>'left'</strong>)<strong>"</strong>&gt;<strong>&amp;leftarrow;</strong>&lt;/<strong>button</strong>&gt;<br /> &nbsp; &lt;<strong>button </strong><strong>id=</strong><strong>"btnPrint" </strong><strong>onclick=</strong><strong>"</strong><em>move</em>(<strong>'print'</strong>)<strong>"</strong>&gt;Print&lt;/<strong>button</strong>&gt;<br /> &lt;/<strong>div</strong>&gt;<br /> &lt;<strong>div </strong><strong>class=</strong><strong>"block"</strong>&gt;<br /> &nbsp; &lt;<strong>div</strong>&gt;Selected towns&lt;/<strong>div</strong>&gt;<br /> &nbsp; &lt;<strong>select </strong><strong>id=</strong><strong>"selected-towns" </strong><strong>size=</strong><strong>"5"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>option</strong>&gt;Plovdiv&lt;/<strong>option</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>option</strong>&gt;Ruse&lt;/<strong>option</strong>&gt;<br /> &nbsp; &lt;/<strong>select</strong>&gt;<br /> &lt;/<strong>div</strong>&gt;<br /> &lt;<strong>div </strong><strong>id=</strong><strong>"output"</strong>&gt;&lt;/<strong>div</strong>&gt;<br /> &lt;<strong>script</strong>&gt;</p>
<strong>&nbsp; function </strong><em>move</em>(command) {<br /> &nbsp;&nbsp;&nbsp; <em>// </em><strong><em>TODO</em></strong>
<p>&nbsp; }</p>
<p>&lt;/<strong>script</strong>&gt;<br /> &lt;/<strong>body</strong>&gt;<br /> &lt;/<strong>html</strong>&gt;</p>
</td>
</tr>
</tbody>
</table>
<h3>Your Task</h3>
<p><strong>Write the missing JavaScript function move()</strong>. When a <strong>button</strong> is <strong>clicked</strong>, the function is called with a string <strong>parameter</strong> (a command):</p>
<ul>
<li>Parameter "<strong>right</strong>" is received when the &agrave; button is <strong>clicked</strong> &ndash; move the selected <strong>town</strong> from <strong>Available</strong> <strong>towns</strong> to <strong>Selected</strong> <strong>towns</strong></li>
<li>Parameter "<strong>left</strong>" is received when the &szlig; button is <strong>clicked</strong> &ndash; move the selected <strong>town</strong> from <strong>Selected</strong> <strong>towns</strong> to <strong>Available</strong> <strong>towns</strong></li>
<li>Parameter "<strong>print</strong>" &ndash; Replace the contents of the <strong>div</strong> element with <strong>ID </strong>"<strong>output</strong>" with a list of the town names of all towns from <strong>Selected towns</strong>, joined with a <strong>semicolon</strong> and <strong>space</strong> ("; ").</li>
</ul>
<p>You should <strong>not</strong> attach <strong>event listeners</strong> to the buttons, they have already been <strong>configured</strong> (see the <strong>HTML skeleton</strong>).</p>
<h3>Examples</h3>
<p>&nbsp;</p>
<h3>Submission</h3>
<p>Submit only your move function.</p>


<h1>JS Advanced: Exam 23 July 2017</h1>
<p>Problems for exam preparation for the <a href="https://softuni.bg/courses/javascript-advanced">&ldquo;JavaScript Advanced&rdquo; course @ SoftUni</a>. Submit your solutions in the SoftUni judge system at <a href="https://judge.softuni.bg/Contests/699/">https://judge.softuni.bg/Contests/699/</a>.</p>
<h1>Problem 2. Sumator Class (Unit Testing)</h1>
<p>You are given the following <strong>JavaScript class</strong>:</p>
<table width="1385">
<tbody>
<tr>
<td width="1385">
<p>sumator.js</p>
</td>
</tr>
<tr>
<td width="1385">
<p><strong>class </strong>Sumator {<br /> &nbsp; constructor() {<br /> &nbsp;&nbsp;&nbsp; <strong>this</strong>.<strong>data </strong>= [];<br /> &nbsp; }<br /> &nbsp; add(item) {<br /> &nbsp;&nbsp;&nbsp; <strong>this</strong>.<strong>data</strong>.push(item);<br /> &nbsp; }<br /> &nbsp; sumNums() {<br /> &nbsp;&nbsp;&nbsp; <strong>let </strong>sum = 0;<br /> &nbsp;&nbsp;&nbsp; <strong>for </strong>(<strong>let </strong>item <strong>of this</strong>.<strong>data</strong>)<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>if </strong>(<strong>typeof </strong>(item) === <strong>'number'</strong>)<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; sum += item;<br /> &nbsp;&nbsp;&nbsp; <strong>return </strong>sum;<br /> &nbsp; }<br /> &nbsp; removeByFilter(filterFunc) {<br /> &nbsp;&nbsp;&nbsp; <strong>this</strong>.<strong>data </strong>= <strong>this</strong>.<strong>data</strong>.filter(x =&gt; !filterFunc(x));<br /> &nbsp; }<br /> &nbsp; toString() {<br /> &nbsp;&nbsp;&nbsp; <strong>if </strong>(<strong>this</strong>.<strong>data</strong>.<strong>length </strong>&gt; 0)<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>return this</strong>.<strong>data</strong>.join(<strong>", "</strong>);<br /> &nbsp;&nbsp;&nbsp; <strong>else<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; return </strong><strong>'(empty)'</strong>;<br /> &nbsp; }<br /> }</p>
</td>
</tr>
</tbody>
</table>
<h3>Functionality</h3>
<p>The above code defines a <strong>class</strong> that holds items (of <strong>any</strong> type). An <strong>instance</strong> of the class should support the following operations:</p>
<ul>
<li>Contains a property data that is initialized to an <strong>empty</strong></li>
<li>Function add(item) &ndash; <strong>adds</strong> the passed in <strong>item</strong> (of <strong>any</strong> type) to the data.</li>
<li>Function sumNums() &ndash; <strong>sums</strong> only the <strong>numbers</strong> from the data and <strong>returns</strong> the sum. If there are <strong>no</strong> numbers stored, the function should return <strong>zero</strong>.</li>
<li>Function removeByFilter(filterFunc) &ndash; <strong>filters</strong> the data by a given <strong>function</strong>. All of the items that <strong>match</strong> the criteria should be <strong>removed</strong>.</li>
<li>Function toString() &ndash; <strong>returns</strong> a string, containing a list of all items from the data, joined with a <strong>comma</strong> and a <strong>space</strong>. If there are <strong>no</strong> items stored, it should <strong>return</strong> the string <strong>"(empty)".</strong></li>
</ul>
<p>&nbsp;</p>
<h3>Examples</h3>
<p>This is an example how this code is <strong>intended to be used</strong>:</p>
<table width="1385">
<tbody>
<tr>
<td width="847">
<p>Sample code usage</p>
</td>
<td rowspan="2" width="57">
<p>&nbsp;</p>
</td>
<td width="481">
<p>Corresponding output</p>
</td>
</tr>
<tr>
<td width="847">
<p><strong>let </strong>list = <strong>new </strong>Sumator();</p>
<p>console.log(<strong>`list = [</strong>${list}<strong>]`</strong>);<br /> list.add(1);<br /> list.add(2);<br /> list.add(<strong>"three"</strong>);<br /> list.add(4);<br /> console.log(<strong>`list = [</strong>${list}<strong>]`</strong>);<br /> console.log(<strong>"sum = " </strong>+ list.sumNums());<br /> list.add(<strong>"5.5"</strong>); <em>// not a number!<br /> </em>list.add(7.7);<br /> console.log(<strong>`list = [</strong>${list}<strong>]`</strong>);<br /> console.log(<strong>"sum = " </strong>+ list.sumNums());<br /> list.removeByFilter(x =&gt; x % 2 === 0);<br /> console.log(<strong>`list = [</strong>${list}<strong>]`</strong>);<br /> console.log(<strong>"sum = " </strong>+ list.sumNums());</p>
</td>
<td width="481">list = [(empty)]list = [1, 2, three, 4]sum = 7list = [1, 2, three, 4, 5.5, 7.7]sum = 14.7list = [1, three, 5.5, 7.7]sum = 8.7</td>
</tr>
</tbody>
</table>
<h3>Your Task</h3>
<p>Using <strong>Mocha</strong> and <strong>Chai</strong> write <strong>JS unit tests</strong> to test the entire functionality of the Sumator class. Make sure it is correctly defined as a class and instances of it have all the required functionality. You should have at least <strong>7 test cases</strong>. You may use the following code as a template:</p>
<table width="1385">
<tbody>
<tr>
<td width="1385">describe(<strong>"<em>TODO</em> &hellip;"</strong>, <strong>function</strong>() {<br /> &nbsp;&nbsp;&nbsp; <strong><em>it</em></strong>(<strong>"<em>TODO &hellip;</em>"</strong>, <strong>function</strong>() {&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <em>// </em><strong><em>TODO: </em></strong>&hellip;&nbsp;&nbsp;&nbsp; });<br /> &nbsp;&nbsp;&nbsp; <em>// </em><strong><em>TODO: </em></strong>&hellip;});</td>
</tr>
</tbody>
</table>
<h3>Submission</h3>
<p>Submit your tests inside a describe() statement.</p>
<p>&nbsp;</p>


<h1>JS Advanced: Exam 23 July 2017</h1>
<p>Problems for exam preparation for the <a href="https://softuni.bg/courses/javascript-advanced">&ldquo;JavaScript Advanced&rdquo; course @ SoftUni</a>. Submit your solutions in the SoftUni judge system at <a href="https://judge.softuni.bg/Contests/699/">https://judge.softuni.bg/Contests/699/</a>.</p>
<h1>Problem 3. Task (Simple Class)</h1>
<p>Write a <strong>JavaScript class</strong> Task that has a <strong>title</strong>, a <strong>deadline</strong> and a <strong>status</strong>.</p>
<table width="1391">
<tbody>
<tr>
<td width="1391">
<p><strong>class </strong>Task {<br /> &nbsp;&nbsp;&nbsp; <em>// </em><strong><em>TODO: implement this class<br /> </em></strong>}</p>
</td>
</tr>
</tbody>
</table>
<p>The class <strong>constructor</strong> should receive two parameters &ndash; <strong>title</strong> (string), and <strong>deadline</strong> (JS Date object) and initialize the instance with <strong>status</strong> "Open". Implement the following features:</p>
<ul>
<li>Property title</li>
<li>Property deadline</li>
<li>Property status &ndash; will be either "Open", "In Progress" or "Complete" (there is no need to check)</li>
<li>Property isOverdue &ndash; holds <strong>true</strong> if the <strong>deadline</strong> has been exceeded (the value is in the <strong>past</strong>) <strong>and</strong> the task is not completed</li>
<li><strong>Static</strong> function comparator(a, b) for <strong>sorting</strong> &ndash; see bellow for sorting instructions</li>
<li>Function toString() &ndash; returns a string representation of a task in the following format:</li>
</ul>
<p>[{status icon}] {title} {(deadline: {deadline})|(overdue)}</p>
<p>Print all <strong>deadlines</strong> in their <strong>default format</strong> (no additional formatting is required). If a task is <strong>overdue</strong>, print "<strong>(overdue)</strong>" instead of a deadline, and if a task is <strong>complete</strong>, do not print anything after the title. A task&rsquo;s <strong>status </strong><strong>icon</strong> depends on its <strong>status and deadline</strong>:</p>
<table width="756">
<tbody>
<tr>
<td width="454">
<p><strong>Status</strong></p>
</td>
<td width="113">
<p><strong>Icon</strong></p>
</td>
<td width="189">
<p><strong>UTF Code</strong></p>
</td>
</tr>
<tr>
<td width="454">
<p>"Open"</p>
</td>
<td width="113">
<p>?</p>
</td>
<td width="189">
<p>"<em>\u2731"</em></p>
</td>
</tr>
<tr>
<td width="454">
<p>"In Progress"</p>
</td>
<td width="113">
<p>?</p>
</td>
<td width="189">
<p>"<em>\u219D</em> "</p>
</td>
</tr>
<tr>
<td width="454">
<p>"Complete"</p>
</td>
<td width="113">
<p>?</p>
</td>
<td width="189">
<p>"<em>\u2714</em>"</p>
</td>
</tr>
<tr>
<td width="454">
<p>Overdue tasks (except "Complete")</p>
</td>
<td width="113">
<p>?</p>
</td>
<td width="189">
<p>"<em>\u26A0</em>"</p>
</td>
</tr>
</tbody>
</table>
<p>See the examples for more formatting details.</p>
<p>Additionally, each instance must meet some <strong>requirements</strong>. A task should <strong>not</strong> <strong>be created</strong>, if its <strong>deadline</strong> is set to a <strong>past date</strong> &ndash; it should <strong>throw an Error</strong>. After creation, if the deadline is <strong>changed</strong> to a past date, an Error should be thrown. To determine whether a date is in the past, compare it with Date.now().</p>
<p>When printing, sorting, or returning isOverdue, consider the task&rsquo;s status &ndash; "Completed" tasks are <strong>not</strong> overdue.</p>
<p>The <strong>comparator</strong> is function that <strong>takes</strong> <strong>two</strong> task instances as <strong>parameters</strong> and <strong>returns a number</strong>, depending on how they compare. If a should sort higher than b, return a <strong>negative number</strong>, if they are <strong>equal</strong>, return <strong>zero</strong>, and if b should sort higher than a, return a <strong>positive number</strong>. Overdue tasks are sorted highest (unless their <strong>status</strong> is "Complete"), "In Progress" tasks come second, "Open" tasks come third and "Complete&rdquo; tasks sort lowest. If two tasks have the same status or are both overdue, sort them by <strong>deadline</strong> in ascending order (see the examples for details).</p>
<h3>Examples</h3>
<p>This is an example how the Task class is <strong>intended to be used</strong>:</p>
<table width="1391">
<tbody>
<tr>
<td width="1391">
<p>Sample code usage</p>
</td>
</tr>
<tr>
<td width="1391">
<p><strong>let </strong><strong><em>date1 </em></strong>= <strong>new </strong>Date();<br /> <strong><em>date1</em></strong>.setDate(<strong><em>date1</em></strong>.getDate() + 7); <em>// Set date 7 days from now<br /> </em><strong>let </strong><strong><em>task1 </em></strong>= <strong>new </strong>Task(<strong>'JS Homework'</strong>, <strong><em>date1</em></strong>);<br /> <strong>let </strong><strong><em>date2 </em></strong>= <strong>new </strong>Date();<br /> <strong><em>date2</em></strong>.setFullYear(<strong><em>date2</em></strong>.getFullYear() + 1); <em>// Set date 1 year from now<br /> </em><strong>let </strong><strong><em>task2 </em></strong>= <strong>new </strong>Task(<strong>'Start career'</strong>, <strong><em>date2</em></strong>);<br /> <strong><em>console</em></strong>.log(<strong><em>task1 </em></strong>+ <strong>'</strong><strong>\n</strong><strong>' </strong>+ <strong><em>task2</em></strong>);<br /> <strong>let </strong><strong><em>date3 </em></strong>= <strong>new </strong>Date();<br /> <strong><em>date3</em></strong>.setDate(<strong><em>date3</em></strong>.getDate() + 3); <em>// Set date 3 days from now<br /> </em><strong>let </strong><strong><em>task3 </em></strong>= <strong>new </strong>Task(<strong>'football'</strong>, <strong><em>date3</em></strong>);<br /> <em>// Create two tasks with deadline set to current time<br /> </em><strong>let </strong><strong><em>task4 </em></strong>= <strong>new </strong>Task(<strong>'Task 4'</strong>, <strong>new </strong>Date()); <br /> <strong>let </strong><strong><em>task5 </em></strong>= <strong>new </strong>Task(<strong>'Task 5'</strong>, <strong>new </strong>Date());<br /> <strong><em>task1</em></strong>.<strong>status </strong>= <strong>'In Progress'</strong>;<br /> <strong><em>task3</em></strong>.<strong>status </strong>= <strong>'In Progress'</strong>;<br /> <strong><em>task5</em></strong>.<strong>status </strong>= <strong>"Complete"</strong>;<br /> <strong>let </strong><strong><em>tasks </em></strong>= [<strong><em>task1</em></strong>, <strong><em>task2</em></strong>, <strong><em>task3</em></strong>, <strong><em>task4</em></strong>, <strong><em>task5</em></strong>];<br /> <em>setTimeout</em>(() =&gt; {<br /> &nbsp; <strong><em>tasks</em></strong>.sort(Task.<em>comparator</em>);<br /> &nbsp; <strong><em>console</em></strong>.log(<strong><em>tasks</em></strong>.join(<strong>'</strong><strong>\n</strong><strong>'</strong>));<br /> }, 1000); <em>// Sort and print one second later</em></p>
<p><em>&nbsp;</em></p>
<p><em>// should throw an Error</em></p>
<p><strong>let </strong><strong><em>overdueTask </em></strong>= <strong>new </strong>Task(<strong>'Overdue Task'</strong>, <strong>new </strong>Date(<strong>2005</strong>, <strong>'4'</strong>, <strong>'20'</strong>));</p>
<p><em>// should throw an Error</em></p>
<p><strong><em>task1</em></strong>.<strong>deadline </strong>= <strong>new </strong>Date(<strong>2005</strong>, <strong>'4'</strong>, <strong>'20'</strong>);</p>
</td>
</tr>
<tr>
<td width="1391">
<p>Corresponding output</p>
</td>
</tr>
<tr>
<td width="1391">[?] JS Homework (deadline: Wed Jul 26 2017 11:52:23 GMT+0300 (FLE Daylight Time))[?] Start career (deadline: Thu Jul 19 2018 11:52:23 GMT+0300 (FLE Daylight Time))&nbsp;[?] Task 4 (overdue)[?] football (deadline: Sat Jul 22 2017 11:52:23 GMT+0300 (FLE Daylight Time))[?] JS Homework (deadline: Wed Jul 26 2017 11:52:23 GMT+0300 (FLE Daylight Time))[?] Start career (deadline: Thu Jul 19 2018 11:52:23 GMT+0300 (FLE Daylight Time))[?] Task 5</td>
</tr>
</tbody>
</table>
<p>Task 5 is overdue, but it&rsquo;s status is "Complete". Tasks "football" and "JS Homework" has the same status and are sorted by deadline. Note that date <strong>formatting is not considered</strong> in the Judge and may differ in your solution!</p>
<h3>Constraints</h3>
<ul>
<li>Your class will be tested with both <strong>valid and invalid deadlines</strong> and should throw and Error for invalid values</li>
<li>Your class will be tested with <strong>only valid statuses</strong> &ndash; "Open", "In Progress" and "Complete"</li>
</ul>
<h3>Submission</h3>
<p>Submit <strong>only</strong> your class Task.</p>


<h1>JS Advanced: Exam 23 July 2017</h1>
<p>Problems for exam preparation for the <a href="https://softuni.bg/courses/javascript-advanced">&ldquo;JavaScript Advanced&rdquo; course @ SoftUni</a>. Submit your solutions in the SoftUni judge system at <a href="https://judge.softuni.bg/Contests/699/">https://judge.softuni.bg/Contests/699/</a>.</p>
<h1>Problem 4. Contacts Builder (Object Interacting with DOM)</h1>
<p>Write a JS <strong>class</strong> that generates a <strong>contact</strong> info box. You will receive a person's first name, last name, phone and email. Compose the markup for the contact box, attach all the needed events and when a <strong>render</strong> function is called, <strong>append</strong> the newly created element to the document.</p>
<p>A contact info box is <strong>composed</strong> of first name, last name, phone, email (all strings) and a property which indicates if the contact is online or not. Clicking a button on the box <strong>toggles</strong> the visibility of the person's contact information (phone and email). <em>See the examples for more details.</em></p>
<p>The <strong>constructor</strong> of your class needs to take <strong>four</strong> string arguments - first name, last name, phone, email. Additionally, the class should also contain the following functionality:</p>
<ul>
<li>Property online &ndash; Boolean value, initially set to <strong>false</strong></li>
<li>Function render(id) &ndash; takes one string argument, <strong>generates the HTML element</strong> and <strong>appends</strong> it to the element with ID equal to the argument</li>
</ul>
<p>When the value of the online property is changed, the corresponding HTML should be updated &ndash; if it&rsquo;s set to true, add the class "<strong>online</strong>" to the div with class "<strong>title</strong>" (containing the name). If it&rsquo;s false, remove the class "<strong>online</strong>".</p>
<p>A contact info box should have the following HTML structure:</p>
<table width="1391">
<tbody>
<tr>
<td width="1391">
<p>Contact</p>
</td>
</tr>
<tr>
<td width="1391">&lt;<strong>article</strong>&gt;&nbsp;&nbsp;&nbsp; &lt;<strong>div </strong><strong>class=</strong><strong>"title"</strong>&gt;{firstName lastName}&lt;<strong>button</strong>&gt;<strong>&amp;#8505;</strong>&lt;/<strong>button</strong>&gt;&lt;/<strong>div</strong>&gt;&nbsp;&nbsp;&nbsp; &lt;<strong>div </strong><strong>class=</strong><strong>"info"</strong>&gt;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>span</strong>&gt;<strong>&amp;phone; </strong>{phone}&lt;/<strong>span</strong>&gt;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>span</strong>&gt;<strong>&amp;#9993; </strong>{email}&lt;/<strong>span</strong>&gt;&nbsp;&nbsp;&nbsp; &lt;/<strong>div</strong>&gt;&lt;/<strong>article</strong>&gt;</td>
</tr>
</tbody>
</table>
<p>When the box is initialliy creted, the div with class "<strong>info</strong>" must be <strong>hidden</strong>. Clicking the button <strong>toggles its visibility</strong>.</p>
<p>You can use the following HTML skeleton to test your functionality:</p>
<table width="1391">
<tbody>
<tr>
<td width="1391">
<p>contacts.html</p>
</td>
</tr>
<tr>
<td width="1391">&lt;!DOCTYPE <strong>html</strong>&gt;&lt;<strong>html</strong>&gt;&lt;<strong>head</strong>&gt;&nbsp; &lt;<strong>meta </strong><strong>charset=</strong><strong>"UTF-8"</strong>&gt;&nbsp; &lt;<strong>title</strong>&gt;Contacts Builder&lt;/<strong>title</strong>&gt;&nbsp; &lt;<strong>style</strong>&gt;&nbsp;&nbsp;&nbsp; <strong>article </strong>{ <strong>background</strong>: <strong>#EEE</strong>; <strong>padding</strong>: 1<strong>px</strong>; <strong>width</strong>: 250<strong>px</strong>; <strong>margin</strong>: 1<strong>px</strong>; }&nbsp;&nbsp;&nbsp; .<strong>title </strong>{ <strong>background</strong>: <strong>#DDD</strong>; <strong>padding</strong>: 5<strong>px</strong>; <strong>font-weight</strong>: <strong>bold</strong>; }&nbsp;&nbsp;&nbsp; .<strong>title button </strong>{ <strong>float</strong>: <strong>right </strong>}&nbsp;&nbsp;&nbsp; .<strong>info </strong>{ <strong>margin</strong>: 5<strong>px</strong>; }&nbsp;&nbsp;&nbsp; .<strong>info span </strong>{ <strong>display</strong>: <strong>block</strong>; }&nbsp;&nbsp;&nbsp; .<strong>online </strong>{ <strong>background</strong>: <strong>#9E9</strong>; }&nbsp; &lt;/<strong>style</strong>&gt;&nbsp; &lt;<strong>script </strong><strong>src=</strong><strong>"https://code.jquery.com/jquery-3.1.1.min.js"</strong>&gt;&lt;/<strong>script</strong>&gt;&lt;/<strong>head</strong>&gt;&lt;<strong>body</strong>&gt;&lt;<strong>div </strong><strong>id=</strong><strong>"main"</strong>&gt;&lt;/<strong>div</strong>&gt;&lt;/<strong>body</strong>&gt;&lt;/<strong>html</strong>&gt;</td>
</tr>
</tbody>
</table>
<h3>Examples</h3>
<p>Your solution can be <strong>tested</strong> using the following code:</p>
<table width="1391">
<tbody>
<tr>
<td width="1391">
<p>Sample JavaScript</p>
</td>
</tr>
<tr>
<td width="1391">let contacts = [&nbsp; <strong>new </strong>Contact(<strong>"Ivan"</strong>, <strong>"Ivanov"</strong>, <strong>"0888 123 456"</strong>, <strong>"i.ivanov@gmail.com"</strong>),&nbsp; <strong>new </strong>Contact(<strong>"Maria"</strong>, <strong>"Petrova"</strong>, <strong>"0899 987 654"</strong>, <strong>"mar4eto@abv.bg"</strong>),&nbsp; <strong>new </strong>Contact(<strong>"Jordan"</strong>, <strong>"Kirov"</strong>, <strong>"0988 456 789"</strong>, <strong>"jordk@gmail.com"</strong>)];contacts.forEach(c =&gt; c.render(<strong>'main'</strong>));&nbsp;
<p><em>// After 1 second, change the online status to true</em></p>
setTimeout(() =&gt; contacts[1].<strong>online </strong>= <strong>true</strong>, 2000);</td>
</tr>
</tbody>
</table>