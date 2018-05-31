<h1>JS Advanced: Retake Exam 5 September 2017</h1>
<p>Problems for exam preparation for the <a href="https://softuni.bg/courses/javascript-advanced">&ldquo;JavaScript Advanced&rdquo; course @ SoftUni</a>. Submit your solutions in the SoftUni judge system at <a href="https://judge.softuni.bg/Contests/756/">https://judge.softuni.bg/Contests/756/</a>.</p>
<h1>Problem 1. Sort Table (Simple DOM Interaction)</h1>
<p>You are given the following <strong>HTML code</strong>:</p>
<table width="1385">
<tbody>
<tr>
<td width="1385">
<p>sort-table.html</p>
</td>
</tr>
<tr>
<td width="1385">&lt;!DOCTYPE <strong>html</strong>&gt;<br /> &lt;<strong>html </strong><strong>lang=</strong><strong>"en"</strong>&gt;<br /> &lt;<strong>head</strong>&gt;<br /> &nbsp; &lt;<strong>meta </strong><strong>charset=</strong><strong>"UTF-8"</strong>&gt;<br /> &nbsp; &lt;<strong>title</strong>&gt;Sort Table&lt;/<strong>title</strong>&gt;<br /> &nbsp; &lt;<strong>style</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; <strong>body </strong>{<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>padding</strong>: 30<strong>px</strong>;<br /> &nbsp;&nbsp;&nbsp; }<br /> &nbsp;&nbsp;&nbsp; <strong>table </strong>{<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>border</strong>: 1<strong>px solid black</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>border-collapse</strong>: <strong>collapse</strong>;<br /> &nbsp;&nbsp;&nbsp; }<br /> &nbsp;&nbsp;&nbsp; <strong>th</strong>, <strong>td </strong>{<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>padding</strong>: 5<strong>px </strong>20<strong>px</strong>;<br /> &nbsp;&nbsp;&nbsp; }<br /> &nbsp;&nbsp;&nbsp; <strong>th </strong>{<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>background</strong>: <strong>#cccccc</strong>;<br /> &nbsp;&nbsp;&nbsp; }<br /> &nbsp;&nbsp;&nbsp; <strong>tr</strong>:<strong>nth-child</strong>(<strong>odd</strong>) {<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>background</strong>: <strong>#eeeeee</strong>;<br /> &nbsp;&nbsp;&nbsp; }<br /> &nbsp;&nbsp;&nbsp; <strong>tr</strong>:<strong>nth-child</strong>(<strong>even</strong>) {<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>background</strong>: <strong>#dddddd</strong>;<br /> &nbsp;&nbsp;&nbsp; }<br /> &nbsp;&nbsp;&nbsp; <strong>a </strong>{<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>color</strong>: <strong>black</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>text-decoration</strong>: <strong>none</strong>;<br /> &nbsp;&nbsp;&nbsp; }<br /> &nbsp;&nbsp;&nbsp; <strong>a</strong>:<strong>hover </strong>{<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>color</strong>: <strong>white</strong>;<br /> &nbsp;&nbsp;&nbsp; }<br /> &nbsp;&nbsp;&nbsp; .<strong>active </strong>{<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>color</strong>: <strong>#99ff99</strong>;<br /> &nbsp;&nbsp;&nbsp; }<br /> &nbsp; &lt;/<strong>style</strong>&gt;<br /> &nbsp; &lt;<strong>script </strong><strong>src=</strong><strong>"https://code.jquery.com/jquery-3.1.1.min.js"</strong>&gt;&lt;/<strong>script</strong>&gt;<br /> &lt;/<strong>head</strong>&gt;<br /> &lt;<strong>body</strong>&gt;<br /> <br /> &lt;<strong>h1</strong>&gt;Sort Table&lt;/<strong>h1</strong>&gt;<br /> &lt;<strong>table </strong><strong>id=</strong><strong>"products"</strong>&gt;<br /> &nbsp; &lt;<strong>thead</strong>&gt;<br /> &nbsp; &lt;<strong>tr</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>th</strong>&gt;Name &lt;<strong>a </strong><strong>href=</strong><strong>"javascript:</strong><em>sort</em><strong>(0, false)"</strong>&gt;<strong>&amp;#x25B2;</strong>&lt;/<strong>a</strong>&gt; &lt;<strong>a </strong><strong>href=</strong><strong>"javascript:</strong><em>sort</em><strong>(0, true)"</strong>&gt;<strong>&amp;#x25BC;</strong>&lt;/<strong>a</strong>&gt;&lt;/<strong>th</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>th</strong>&gt;Price &lt;<strong>a </strong><strong>href=</strong><strong>"javascript:</strong><em>sort</em><strong>(1, false)"</strong>&gt;<strong>&amp;#x25B2;</strong>&lt;/<strong>a</strong>&gt; &lt;<strong>a </strong><strong>href=</strong><strong>"javascript:</strong><em>sort</em><strong>(1, true)"</strong>&gt;<strong>&amp;#x25BC;</strong>&lt;/<strong>a</strong>&gt;&lt;/<strong>th</strong>&gt;<br /> &nbsp; &lt;/<strong>tr</strong>&gt;<br /> &nbsp; &lt;/<strong>thead</strong>&gt;<br /> &nbsp; &lt;<strong>tbody</strong>&gt;<br /> &nbsp; &lt;<strong>tr</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>td</strong>&gt;Potatoes&lt;/<strong>td</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>td</strong>&gt;0.89&lt;/<strong>td</strong>&gt;<br /> &nbsp; &lt;/<strong>tr</strong>&gt;<br /> &nbsp; &lt;<strong>tr</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>td</strong>&gt;Tomatoes&lt;/<strong>td</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>td</strong>&gt;2.30&lt;/<strong>td</strong>&gt;<br /> &nbsp; &lt;/<strong>tr</strong>&gt;<br /> &nbsp; &lt;<strong>tr</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>td</strong>&gt;Bananas&lt;/<strong>td</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>td</strong>&gt;1.79&lt;/<strong>td</strong>&gt;<br /> &nbsp; &lt;/<strong>tr</strong>&gt;<br /> &nbsp; &lt;/<strong>tbody</strong>&gt;<br /> &lt;/<strong>table</strong>&gt;<br /> <br /> &lt;<strong>script</strong>&gt;<br /> <strong>function </strong><em>sort</em>(colIndex, descending) {<br /> &nbsp; <em>//</em><strong><em>TODO: <br /> </em></strong>}
<p>&lt;/<strong>script</strong>&gt;<br /> <br /> &lt;/<strong>body</strong>&gt;<br /> &lt;/<strong>html</strong>&gt;</p>
</td>
</tr>
</tbody>
</table>
<h3>Your Task</h3>
<p><strong>Write the missing JavaScript function sort()</strong>, that <strong>sorts</strong> the table depending on the passed in <strong>arguments</strong>. The table will always have <strong>two</strong> columns, first column is a string (<strong>name</strong> of a product) and the second a number (<strong>price</strong> of a product). The first parameter is the <strong>column</strong> <strong>index</strong> which is either 0 or 1 (name column or price column), the second parameter is a <strong>Boolean</strong> variable which <strong>indicates</strong> whether the sorting is <strong>descending</strong> or <strong>ascending</strong>.</p>
<ul>
<li>Depending on the pressed button the sorting is either ascending or descending.</li>
<li>There are four buttons and each column has two.</li>
</ul>
<p>You should <strong>not</strong> attach <strong>event listeners</strong> to the buttons, they have already been <strong>configured</strong> (see the <strong>HTML skeleton</strong>).</p>
<h3>Submission</h3>
<p>Submit only your sort function.</p>
<p>&nbsp;</p>
<p><em>Scroll down for examples.</em></p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<h3>Examples</h3>
<table>
<tbody>
<tr>
<td width="695">
<p><strong>Ascending</strong> by <strong>name</strong></p>
</td>
<td width="695">
<p><strong>Descending</strong> by <strong>name</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p><strong>Ascending</strong> by <strong>price</strong></p>
</td>
<td width="695">
<p><strong>Descending</strong> by <strong>price</strong></p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>


<h1>JS Advanced: Retake Exam 5 September 2017</h1>
<p>Problems for exam preparation for the <a href="https://softuni.bg/courses/javascript-advanced">&ldquo;JavaScript Advanced&rdquo; course @ SoftUni</a>. Submit your solutions in the SoftUni judge system at <a href="https://judge.softuni.bg/Contests/756/">https://judge.softuni.bg/Contests/756/</a>.</p>
<h1>Problem 2. String Builder (Unit Testing)</h1>
<p>You are given the following <strong>JavaScript class</strong>:</p>
<table width="1404">
<tbody>
<tr>
<td width="1404">
<p>string-builder.js</p>
</td>
</tr>
<tr>
<td width="1404">
<p><strong>class </strong>StringBuilder {<br /> &nbsp; constructor(string) {<br /> &nbsp;&nbsp;&nbsp; <strong>if </strong>(string !== <strong><em>undefined</em></strong>) {<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; StringBuilder.<em>_vrfyParam</em>(string);<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>this</strong>.<strong>_stringArray </strong>= Array.from(string);<br /> &nbsp;&nbsp;&nbsp; } <strong>else </strong>{<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>this</strong>.<strong>_stringArray </strong>= [];<br /> &nbsp;&nbsp;&nbsp; }<br /> &nbsp; }<br /> <br /> &nbsp; append(string) {<br /> &nbsp;&nbsp;&nbsp; StringBuilder.<em>_vrfyParam</em>(string);<br /> &nbsp;&nbsp;&nbsp; <strong>for</strong>(<strong>let </strong>i = 0; i &lt; string.<strong>length</strong>; i++) {<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>this</strong>.<strong>_stringArray</strong>.push(string[i]);<br /> &nbsp;&nbsp;&nbsp; }<br /> &nbsp; }<br /> <br /> &nbsp; prepend(string) {<br /> &nbsp;&nbsp;&nbsp; StringBuilder.<em>_vrfyParam</em>(string);<br /> &nbsp;&nbsp;&nbsp; <strong>for</strong>(<strong>let </strong>i = string.<strong>length </strong>- 1; i &gt;= 0; i--) {<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>this</strong>.<strong>_stringArray</strong>.unshift(string[i]);<br /> &nbsp;&nbsp;&nbsp; }<br /> &nbsp; }<br /> <br /> &nbsp; insertAt(string, startIndex) {<br /> &nbsp;&nbsp;&nbsp; StringBuilder.<em>_vrfyParam</em>(string);<br /> &nbsp;&nbsp;&nbsp; <strong>this</strong>.<strong>_stringArray</strong>.splice(startIndex, 0, ...string);<br /> &nbsp; }<br /> <br /> &nbsp; remove(startIndex, length) {<br /> &nbsp;&nbsp;&nbsp; <strong>this</strong>.<strong>_stringArray</strong>.splice(startIndex, length);<br /> &nbsp; }<br /> <br /> &nbsp; <strong>static </strong><em>_vrfyParam</em>(param) {<br /> &nbsp;&nbsp;&nbsp; <strong>if </strong>(<strong>typeof </strong>param !== <strong>'string'</strong>) <strong>throw new </strong><strong>TypeError</strong>(<strong>'Argument must be string'</strong>);<br /> &nbsp; }<br /> <br /> &nbsp; toString() {<br /> &nbsp;&nbsp;&nbsp; <strong>return this</strong>.<strong>_stringArray</strong>.join(<strong>''</strong>);<br /> &nbsp; }<br /> }</p>
</td>
</tr>
</tbody>
</table>
<h3>Functionality</h3>
<p>The above code defines a <strong>class</strong> that holds <strong>characters</strong> (strings with length 1) in an array. An <strong>instance</strong> of the class should support the following operations:</p>
<ul>
<li>Can be <strong>instantiated</strong> with a passed in <strong>string</strong> argument or <strong>without</strong> anything</li>
<li>Function append(string) &ndash; <strong>converts</strong> the passed in <strong>string </strong>argument to an <strong>array</strong> and adds it to the <strong>end</strong> of the storage</li>
<li>Function <strong>prepend</strong>(<strong>string</strong>) &ndash; <strong>converts</strong> the passed in <strong>string</strong> argument to an <strong>array</strong> and adds it to the <strong>beginning</strong> of the storage</li>
<li>Function insertAt(string, index) &ndash; <strong>converts</strong> the passed in <strong>string </strong>argument to an <strong>array</strong> and adds it at the <strong>given</strong> index (there is <strong>no</strong> need to check if the index is in range)</li>
<li>Function remove(startIndex, length) &ndash; <strong>removes</strong> elements from the storage, starting at the given index (<strong>inclusive</strong>), <strong>length</strong> number of characters (there is <strong>no</strong> need to check if the index is in range)</li>
<li>Function toString() &ndash; <strong>returns </strong>a string with <strong>all</strong> elements joined by an <strong>empty</strong> string</li>
<li>All passed in <strong>arguments</strong> should be If any of them are <strong>not</strong>, <strong>throws</strong> a type <strong>error</strong> with the following message: "<strong>Argument must be a string</strong>"</li>
</ul>
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
<p><strong>let </strong>str = <strong>new </strong>StringBuilder(<strong>'hello'</strong>);<br /> str.append(<strong>', there'</strong>);<br /> str.prepend(<strong>'User, '</strong>);<br /> str.insertAt(<strong>'woop'</strong>,5 );<br /> <strong>console</strong>.log(str.toString());<br /> str.remove(6, 3);<br /> <strong>console</strong>.log(str.toString());</p>
</td>
<td width="481">User,woop hello, thereUser,w hello, there</td>
</tr>
</tbody>
</table>
<h3>Your Task</h3>
<p>Using <strong>Mocha</strong> and <strong>Chai</strong> write <strong>JS unit tests</strong> to test the entire functionality of the StringBuilder class. Make sure it is <strong>correctly defined as a class</strong> and instances of it have all the required functionality. You may use the following code as a template:</p>
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


<h1>JS Advanced: Retake Exam 5 September 2017</h1>
<p>Problems for exam preparation for the <a href="https://softuni.bg/courses/javascript-advanced">&ldquo;JavaScript Advanced&rdquo; course @ SoftUni</a>. Submit your solutions in the SoftUni judge system at <a href="https://judge.softuni.bg/Contests/756/">https://judge.softuni.bg/Contests/756/</a>.</p>
<h1>Problem 3. Repository (Simple Class)</h1>
<p>Write a JavaScript class Repository that has <strong>props</strong> (object that will validate an entity) and <strong>data</strong> (a Map which stores entities). All entities inside the repository have the <strong>same properties</strong> (listed in the props) and a <strong>unique ID</strong>, that is assigned when they are added, <strong>starting at zero</strong>.</p>
<table width="1391">
<tbody>
<tr>
<td width="1391">
<p><strong>class </strong>Repository {<br /> &nbsp;&nbsp;&nbsp; <em>// </em><strong><em>TODO: implement this class<br /> </em></strong>}</p>
</td>
</tr>
</tbody>
</table>
<p>The class <strong>constructor</strong> should receive one parameter &ndash; <strong>props</strong> (object), and initialize the <strong>data</strong> with a new <strong>Map</strong> instance<strong>. </strong>Implement the following features:</p>
<ul>
<li>Property data &ndash; <strong>Map</strong> that holds added entities</li>
<li>Function add(entity) &ndash; adds an entity to the data; if successful, returns the resulting ID</li>
<li>Function get(id) &ndash; returns the entity with given ID</li>
<li>Function update(id, newEntity) &ndash; replaces the entity with the given id with the new entity</li>
<li>Function del(id) &ndash; deletes an entity by given id</li>
<li>Getter count &ndash; returns the number of stored entities</li>
</ul>
<p>The <strong>props </strong>parameter is used to <strong>validate</strong> entities added to the repository and is an object with format:</p>
<p>{</p>
<p>&nbsp; propName1: propType1,</p>
<p>&nbsp; propName2: propType2,</p>
<p>&nbsp; &hellip;</p>
<p>&nbsp; propNameN: propTypeN</p>
<p>}</p>
<p>When an entity is <strong>added</strong> to the repository, it should be <strong>validated</strong> against the props object &ndash; it needs to have all of the properties that the props object has and their values must be of the specified type. For example, if props has a property "name" with value "string", all entities added must have a <strong>name</strong> property with value of type <strong>string</strong>. If <strong>any</strong> property is <strong>missing</strong>, you should <strong>throw</strong> an <strong>Error</strong> with message: "<strong>Property {propName} is missing from the entity!</strong>". If the property is present, but is of <strong>incorrect</strong> type, <strong>throw</strong> a <strong>TypeError</strong> with message "<strong>Property {propertName} is of incorrect type!</strong>"<strong>. </strong>If validation is successful, add the entity to the repository with a new ID. Store entities in a Map where the key is the ID and the value is the entity.</p>
<p>To <strong>update</strong> an entity, we receive its <strong>id</strong> and the <strong>new</strong> entity object. If the id does <strong>not</strong> exist in the <strong>data</strong> throw an <strong>Error</strong> with message "<strong>Entity with id: {id} does not exist!</strong>". Validate the <strong>new</strong> entity with the <strong>same</strong> validations and <strong>replace</strong> the old one with the new one.</p>
<p>To <strong>delete</strong> an entity, we receive only its <strong>id</strong>. If the id does <strong>not</strong> exist in the <strong>data</strong> throw an <strong>Error</strong> with message "<strong>Entity with id: {id} does not exist!</strong>". After that <strong>remove</strong> the entity from the <strong>map</strong>.</p>
<p>&nbsp;</p>
<h3>Examples</h3>
<p>This is an example how the Repository class is <strong>intended to be used</strong>. Make sure to comment out the parts that throw an error!</p>
<table width="1391">
<tbody>
<tr>
<td width="1391">
<p>Sample code usage</p>
</td>
</tr>
<tr>
<td width="1391">
<p><em>// Initialize props object<br /> </em><strong>let </strong><strong><em>properties </em></strong>= {<br /> &nbsp;&nbsp;&nbsp; <strong>name</strong>: <strong>"string"</strong>,<br /> &nbsp;&nbsp;&nbsp; <strong>age</strong>: <strong>"number"</strong>,<br /> &nbsp;&nbsp;&nbsp; <strong>birthday</strong>: <strong>"object"<br /> </strong>};<br /> <em>//Initialize the repository<br /> </em><strong>let </strong><strong><em>repository </em></strong>= <strong>new </strong><strong><em>Repository</em></strong>(<strong><em>properties</em></strong>);<br /> <em>// Add two entities<br /> </em><strong>let </strong><strong><em>entity </em></strong>= {<br /> &nbsp;&nbsp;&nbsp; <strong>name</strong>: <strong>"Kiril"</strong>,<br /> &nbsp;&nbsp;&nbsp; <strong>age</strong>: 19,<br /> &nbsp;&nbsp;&nbsp; <strong>birthday</strong>: <strong>new </strong>Date(1998, 0, 7)<br /> };<br /> <strong><em>repository</em></strong>.add(<strong><em>entity</em></strong>); <em>// </em><em>Returns </em><em>0</em><br /> <strong><em>repository</em></strong>.add(<strong><em>entity</em></strong>); <em>// </em><em>Returns </em><em>1</em><br /> <strong>console</strong>.log(<strong><em>repository</em></strong>.get(0));</p>
<p><em>// {"name":"Kiril","age":19,"birthday":"1998-01-06T22:00:00.000Z"}</em></p>
<p><strong>console</strong>.log(<strong><em>repository</em></strong>.get(1));</p>
<p><em>// {"name":"Kiril","age":19,"birthday":"1998-01-06T22:00:00.000Z"}<br /> //Update an entity<br /> </em><strong><em>entity </em></strong>= {<br /> &nbsp;&nbsp;&nbsp; <strong>name</strong>: <strong>'Valio'</strong>,<br /> &nbsp;&nbsp;&nbsp; <strong>age</strong>: 19,<br /> &nbsp;&nbsp;&nbsp; <strong>birthday</strong>: <strong>new </strong>Date(1998, 0, 7)<br /> };<br /> <strong><em>repository</em></strong>.update(1, <strong><em>entity</em></strong>);<br /> <strong>console</strong>.log(<strong><em>repository</em></strong>.get(1));</p>
<p><em>// {"name":"Valio","age":19,"birthday":"1998-01-06T22:00:00.000Z"}<br /> // Delete an entity<br /> </em><strong><em>repository</em></strong>.del(0);<br /> <strong>console</strong>.log(<strong><em>repository</em></strong>.count); <em>// </em><em>Returns </em><em>1</em></p>
<p><strong>let </strong><strong><em>anotherEntity </em></strong>= {<br /> &nbsp;&nbsp;&nbsp; <strong>name1</strong>: <strong>'Nakov'</strong>,<br /> &nbsp;&nbsp;&nbsp; <strong>age</strong>: 26,<br /> &nbsp;&nbsp;&nbsp; <strong>birthday</strong>: <strong>new </strong>Date(1991, 0, 21)<br /> };<br /> <strong><em>repository</em></strong>.add(<strong><em>anotherEntity</em></strong>); <em>// should throw an Error<br /> </em><strong><em>anotherEntity </em></strong>= {<br /> &nbsp;&nbsp;&nbsp; <strong>name</strong>: <strong>'Nakov'</strong>,<br /> &nbsp;&nbsp;&nbsp; <strong>age</strong>: 26,<br /> &nbsp;&nbsp;&nbsp; <strong>birthday</strong>: 1991<br /> };<br /> <strong><em>repository</em></strong>.add(<strong><em>anotherEntity</em></strong>); <em>// should throw a TypeError<br /> </em><strong><em>repository</em></strong>.del(-1); <em>// should throw Error for invalid id</em></p>
</td>
</tr>
</tbody>
</table>
<p>We add <strong>two</strong> entities which are exactly the same. After that the second one is <strong>updated</strong> with a <strong>different</strong> name and lastly, we <strong>delete</strong> the entity with id <strong>zero</strong>. The corresponding output is <strong>without</strong> the errors.</p>
<h3>Constraints</h3>
<ul>
<li>The ID should change <strong>only</strong> when we <strong>add</strong> a new entity.</li>
<li>The ID is unique per repository &ndash; if two repositories are instantiated, each has its own counter.</li>
</ul>
<h3>Submission</h3>
<p>Submit <strong>only</strong> your class Repository.</p>
<h3>Hints</h3>
<p>Use typeof of determine the type of a property.</p>


<h1>JS Advanced: Retake Exam 5 September 2017</h1>
<p>Problems for exam preparation for the <a href="https://softuni.bg/courses/javascript-advanced">&ldquo;JavaScript Advanced&rdquo; course @ SoftUni</a>. Submit your solutions in the SoftUni judge system at <a href="https://judge.softuni.bg/Contests/756/">https://judge.softuni.bg/Contests/756/</a>.</p>
<h1>Problem 4. Modal Dialog (Object Interacting with DOM)</h1>
<p>Write a JS <strong>class</strong> that generates and controls a <strong>modal dialog </strong>box. It contains a text message, OK and Cancel buttons and optionally input fields and overlays the rest of the website content. When the user clicks OK, a callback is executed with the values of all input fields. <em>See the examples for more details.</em></p>
<p>The <strong>constructor</strong> of your class needs to take <strong>two</strong> arguments &ndash; text message (string) and callback (function). The callback is a function that must be executed when the user clicks OK. Additionally, the class should contain the following functionality:</p>
<ul>
<li>Function addInput(label, name, type) &ndash; takes three string arguments and adds an input field to the dialog, with name and type attributes as specified</li>
<li>Function render() &ndash; <strong>generates the HTML content</strong> and <strong>appends</strong> it to the end of the <strong>document&rsquo;s body</strong></li>
</ul>
<p>The dialog has <strong>two buttons</strong> &ndash; OK and Cancel. When OK is clicked, the <strong>callback</strong> of the dialog is executed and the dialog is closed (<strong>removed</strong> from the page). If the dialog had any input fields, their <strong>values</strong> are collected in an <strong>object</strong> with their <strong>names as keys</strong>, and the object is used as a <strong>parameter to the callback</strong>. If Cancel is clicked, the dialog is closed (removed from the page), without any side effect.</p>
<p>A dialog box should have the following HTML structure:</p>
<table width="1391">
<tbody>
<tr>
<td width="1391">
<p>Dialog</p>
</td>
</tr>
<tr>
<td width="1391">&lt;<strong>div </strong><strong>class=</strong><strong>"overlay"</strong>&gt;<br /> &nbsp; &lt;<strong>div </strong><strong>class=</strong><strong>"dialog"</strong>&gt;&nbsp;&nbsp;&nbsp; &lt;<strong>p</strong>&gt;Dialog, containing message text and input field.&lt;/<strong>p</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>label</strong>&gt;Name&lt;/<strong>label</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>input </strong><strong>name=</strong><strong>"name" </strong><strong>type=</strong><strong>"text"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>button</strong>&gt;OK&lt;/<strong>button</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>button</strong>&gt;Cancel&lt;/<strong>button</strong>&gt;<br /> &nbsp; &lt;/<strong>div</strong>&gt;<br /> &lt;/<strong>div</strong>&gt;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
</tr>
</tbody>
</table>
<p>The paragraph contains the <strong>message</strong>, that is entered trough the constructor. The label and input field have been added using the addInput() function. If two dialogs are created, they should <strong>not interfere</strong> with each other&rsquo;s functionality &ndash; closing one does not affect the other.</p>
<p>You can use the following HTML skeleton to test your functionality:</p>
<table width="1391">
<tbody>
<tr>
<td width="1391">
<p>index.html</p>
</td>
</tr>
<tr>
<td width="1391">
<p>&lt;!DOCTYPE <strong>html</strong>&gt;<br /> &lt;<strong>html </strong><strong>lang=</strong><strong>"en"</strong>&gt;<br /> &lt;<strong>head</strong>&gt;<br /> &nbsp; &lt;<strong>meta </strong><strong>charset=</strong><strong>"UTF-8"</strong>&gt;<br /> &nbsp; &lt;<strong>title</strong>&gt;Modal Overlay&lt;/<strong>title</strong>&gt;<br /> &nbsp; &lt;<strong>style</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; .<strong>overlay </strong>{<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>position</strong>: <strong>fixed</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>left</strong>: 0;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>right</strong>: 0;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>top</strong>: 0;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>bottom</strong>: 0;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>background</strong>: <strong>rgba</strong>(0, 0, 0, 0.5);<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>text-align</strong>: <strong>center</strong>;<br /> &nbsp;&nbsp;&nbsp; }<br /> <br /> &nbsp;&nbsp;&nbsp; .<strong>dialog </strong>{<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>border</strong>: 1<strong>px solid black</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>background</strong>: <strong>#eeeeee</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>display</strong>: <strong>inline-block</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>margin</strong>: 40<strong>vh auto</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>padding</strong>: 1<strong>em </strong>3<strong>em</strong>;<br /> &nbsp;&nbsp;&nbsp; }<br /> &nbsp; &lt;/<strong>style</strong>&gt;<br /> &nbsp; &lt;<strong>script </strong><strong>src=</strong><strong>"https://code.jquery.com/jquery-3.1.1.min.js"</strong>&gt;&lt;/<strong>script</strong>&gt;<br /> &lt;/<strong>head</strong>&gt;<br /> &lt;<strong>body</strong>&gt;<br /> <br /> &lt;<strong>h1</strong>&gt;Modal Dialog Overlay&lt;/<strong>h1</strong>&gt;<br /> &lt;<strong>button </strong><strong>onclick=</strong><strong>"</strong><em>spawnConfirm</em>()<strong>"</strong>&gt;Create OK/Cancel&lt;/<strong>button</strong>&gt;<br /> &lt;<strong>button </strong><strong>onclick=</strong><strong>"</strong><em>spawnInput</em>()<strong>"</strong>&gt;Create Input&lt;/<strong>button</strong>&gt;<br /> &lt;<strong>textarea </strong><strong>style=</strong><strong>"</strong><strong>resize</strong>: <strong>none</strong>; <strong>display</strong>: <strong>block</strong>; <strong>width</strong>: 300<strong>px</strong>; <strong>height</strong>: 200<strong>px" </strong><strong>disabled id=</strong><strong>"output"</strong>&gt;&lt;/<strong>textarea</strong>&gt;<br /> <br /> &lt;<strong>script </strong><strong>src=</strong><strong>"solution.js"</strong>&gt;&lt;/<strong>script</strong>&gt;<br /> &lt;<strong>script</strong>&gt;<br /> &nbsp; <strong>function </strong><em>spawnConfirm</em>() {<br /> &nbsp;&nbsp;&nbsp; <em>log</em>(<strong>'Spawning Confirm dialog'</strong>);<br /> &nbsp;&nbsp;&nbsp; let <em>callback </em>= (params) =&gt; {<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <em>log</em>(<strong>'Clicked OK'</strong>);<br /> &nbsp;&nbsp;&nbsp; };<br /> &nbsp;&nbsp;&nbsp; let dialog = <strong>new </strong>Dialog(<strong>"Test Dialog, containing OK and Cancel buttons."</strong>, <em>callback</em>);<br /> &nbsp;&nbsp;&nbsp; dialog.render();<br /> &nbsp; }<br /> <br /> &nbsp; <strong>function </strong><em>spawnInput</em>() {<br /> &nbsp;&nbsp;&nbsp; <em>log</em>(<strong>'Spawning Input dialog'</strong>);<br /> &nbsp;&nbsp;&nbsp; let <em>callback </em>= (params) =&gt; {<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <em>log</em>(<strong>`Params: {</strong>${Object.keys(params).map(k =&gt; k + <strong>': ' </strong>+ params[k]).join(<strong>', '</strong>)}<strong>}`</strong>);<br /> &nbsp;&nbsp;&nbsp; };<br /> &nbsp;&nbsp;&nbsp; let dialog = <strong>new </strong>Dialog(<strong>"Dialog, containing message text and input field."</strong>, <em>callback</em>);<br /> &nbsp;&nbsp;&nbsp; dialog.addInput(<strong>'Name'</strong>, <strong>'name'</strong>, <strong>'text'</strong>);<br /> &nbsp;&nbsp;&nbsp; dialog.render();<br /> &nbsp; }<br /> <br /> &nbsp; <strong>function </strong><em>log</em>(text) {<br /> &nbsp;&nbsp;&nbsp; <strong>document</strong>.getElementById(<strong>'output'</strong>).<strong>textContent </strong>+= text + <strong>'</strong><strong>\n</strong><strong>'</strong>;<br /> &nbsp; }<br /> &lt;/<strong>script</strong>&gt;<br /> &lt;/<strong>body</strong>&gt;<br /> &lt;/<strong>html</strong>&gt;</p>
</td>
</tr>
</tbody>
</table>
<p>The sample page contains two buttons and a script, that will create two different dialogs that should look like the examples, if your code is correct.</p>
<h3>Examples</h3>
<p>If we create a dialog and add two inputs to it, one with name &ldquo;name&rdquo; and type &ldquo;text&rdquo;, and another with name &ldquo;password&rdquo; and type &ldquo;password&rdquo;, when OK is clicked, the callback must be executed with the following object as parameter:</p>
<p>{</p>
<p>&nbsp; name: "pesho",</p>
<p>&nbsp; password: "123456"</p>
<p>}</p>
<p>If there are not inputs, the callback must be executed with an empty object as parameter.</p>