<h1>Exercises: Class Inheritance and Prototypes</h1>
<p>Problems for exercises and homework for the <a href="https://softuni.bg/courses/javascript-advanced">&ldquo;JavaScript Advanced&rdquo; course @ SoftUni</a>. Submit your solutions in the SoftUni judge system at <a href="https://judge.softuni.bg/Contests/339/">https://judge.softuni.bg/Contests/339/.</a></p>
<h2>1.&nbsp;&nbsp; Person and Teacher</h2>
<p>Write a JS <strong>class </strong>Person<strong> and a class </strong>Teacher<strong> which extends </strong>Person<strong>.</strong> A Person should have a name and an email. A Teacher should have a name, an email, and a subject.</p>
<h3>Input</h3>
<p>There will be no input.</p>
<h3>Output</h3>
<p>Your function should return an object containing the classes Person and Teacher.</p>
<h3>Example</h3>
<table width="1388">
<tbody>
<tr>
<td width="1388">
<p>template.js</p>
</td>
</tr>
<tr>
<td width="1388">
<p><strong>function </strong><em>personAndTeacher</em>() {<br /> &nbsp;&nbsp;&nbsp; <em>//</em><strong><em>TODO<br /> <br /> &nbsp;&nbsp;&nbsp; </em></strong><strong>return </strong>{<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong><em>Person</em></strong>,<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong><em>Teacher<br /> &nbsp;&nbsp;&nbsp; </em></strong>}<br /> }</p>
</td>
</tr>
</tbody>
</table>
<h2>2.&nbsp;&nbsp; Inheriting and Replacing ToString</h2>
<p>Extend the Person and Teacher from the previous task and add a class Student inheriting from Person. Add toString() functions to all classes, the formats should be as follows:</p>
<ul>
<li>Person - returns <strong>"<em>Person (name: {name}, email: {email})"</em></strong></li>
<li>Student - returns <strong><em>"Student (name: {name}, email: {email}, course: {course})"</em></strong></li>
<li>Teacher - returns <strong><em>"Teacher (name: {name}, email:{email}, subject:{subject})"</em></strong></li>
</ul>
<p>Try to reuse code by using the toString function of the base class.</p>
<h3>Input</h3>
<p>There will be no input.</p>
<h3>Output</h3>
<p>Your function should return an object containing the classes Person, Teacher and Student.</p>
<h3>Example</h3>
<table width="1388">
<tbody>
<tr>
<td width="1388">
<p>template.js</p>
</td>
</tr>
<tr>
<td width="1388">
<p><strong>function </strong><em>toStringExtension</em>() {<br /> &nbsp;&nbsp;&nbsp; <em>//</em><strong><em>TODO<br /> <br /> &nbsp;&nbsp;&nbsp; </em></strong><strong>return </strong>{<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong><em>Person</em></strong>,<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong><em>Teacher,</em></strong></p>
<p><strong><em>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Student<br /> &nbsp;&nbsp;&nbsp; </em></strong>}<br /> }</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>3.&nbsp;&nbsp; Extend Prototype</h2>
<p>Write a JS <strong>function which receives a class and attaches to it a property </strong>species<strong> and a function </strong>toSpeciesString(). When called, the function returns a string with format:</p>
<p>I am a &lt;species&gt;. &lt;toString()&gt;</p>
<p>The function toString is called from the current instance (call using this).</p>
<h3>Input</h3>
<p>Your function will receive a class whose prototype it should extend.</p>
<h3>Output</h3>
<p>There is no output, your function should only attach the properties to the given class&rsquo; prototype.</p>
<h3>Example</h3>
<table width="1388">
<tbody>
<tr>
<td width="1388">
<p>template.js</p>
</td>
</tr>
<tr>
<td width="1388">
<p><strong>function </strong><em>extendClass</em>(classToExtend) {<br /> &nbsp;&nbsp;&nbsp; <em>//</em><strong><em>TODO</em></strong><br /> }</p>
</td>
</tr>
</tbody>
</table>
<h2>4.&nbsp;&nbsp; Class Hierarchy</h2>
<p>Write a JS function that returns 3 classes - Figure, Circle, Rectangle.</p>
<p>Figure:</p>
<ul>
<li>should be abstract (cannot be instantiated)</li>
</ul>
<p>Circle:</p>
<ul>
<li>extends Figure.</li>
<li>has a property radius</li>
<li>overrides area getter to return the area of the Circle (PI * r * r)</li>
<li>toString() - should return a string representation of the figure in the format <strong>"{type} - radius: {radius}"</strong></li>
</ul>
<p>Rectangle</p>
<ul>
<li>extends Figure</li>
<li>has properties width and height</li>
<li>overrides area getter to return the area of the Rectangle (width * height)</li>
<li>toString() - should return a string representation of the figure in the format <strong>"{type} - width: {width}, height: {height}"</strong></li>
</ul>
<h3>Input</h3>
<p>There will be no input.</p>
<h3>Output</h3>
<p>Your function should return an object containing the Figure, Circle and Rectangle classes.</p>
<h3>Examples</h3>
<p>This code demonstrates how your classes should behave:</p>
<table width="1376">
<tbody>
<tr>
<td width="1376">
<p>Sample Code</p>
</td>
</tr>
<tr>
<td width="1376"><strong>let </strong><strong><em>f </em></strong>= <strong>new </strong>Figure(); &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<strong><em>//Error</em></strong><em><br /> </em><strong>let </strong><strong><em>c </em></strong>= <strong>new </strong>Circle(5);<strong>console</strong>.log(<strong><em>c</em></strong>.area);&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<strong><em>//78.53981633974483</em></strong><br /> <strong>console</strong>.log(<strong><em>c</em></strong>.toString());&nbsp; <strong><em>//Circle - radius: 5</em></strong><em><br /> </em><strong>let </strong><strong><em>r </em></strong>= <strong>new </strong>Rectangle(3,4);<strong>console</strong>.log(<strong><em>r</em></strong>.area);&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<strong><em>//12</em></strong><br /> <strong>console</strong>.log(<strong><em>r</em></strong>.toString());&nbsp; <strong><em>//Rectangle - width: 3, height: 4</em></strong></td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>