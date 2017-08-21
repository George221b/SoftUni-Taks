<h1>Exercises: Unit Testing</h1>
<p>This document defines the exercises for <a href="https://softuni.bg/csharp-basics-oop">"C# OOP Advanced" course @ Software University</a>.</p>
<h2>Problem 1.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Database</h2>
<p>Create a simple class - <strong>Database</strong>. It should <strong>store integers</strong>. You should <strong>set the initial integers by constructor</strong>. Store them <strong>in array</strong>. Your Database should have a functionality to <strong>add</strong>, <strong>remove</strong> and <strong>fetch all stored items</strong>. Your task is to <strong>test the class</strong>. In other words, create the class and <strong>write tests</strong>, so you are sure its methods are working as intended.</p>
<h3>Constraints</h3>
<ul>
<li>Storing array's <strong>capacity</strong> must be <strong>exactly 16 integers</strong>.
<ul>
<li>If the size of the array is not 16 integers long, throw</li>
</ul>
</li>
<li><strong>Add</strong> operation, should <strong>add an element at the next free cell.</strong> (just like a stack)
<ul>
<li>If there are 16 elements in the Database and try to add 17<sup>th</sup> throw <strong>InvalidOperationException</strong></li>
</ul>
</li>
<li><strong>Remove </strong>operation, should support only removing an element <strong>at the last index</strong>. (just like a stack)
<ul>
<li>If you try to remove element from empty Database throw <strong>InvalidOperationException</strong></li>
</ul>
</li>
<li><strong>Constructors </strong>should take integers only, and store them in</li>
<li><strong>Fetch method </strong>should return the elements as</li>
</ul>
<h3>Hint</h3>
<p>Do not forget to <strong>test the constructor(s)</strong>. They are methods too!</p>
<h2>Problem 2.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Extended Database</h2>
<p>You already have a class - <strong>Database</strong>. Now your task is to modify and extend it. It should support, <strong>adding, removing and finding People</strong>. In other words, it should <strong>store People</strong>. There should be two types of finding methods - first: <strong>FindById </strong><strong>(long id)</strong> and the second one: <strong>FindByUsername (string username)</strong>. As you may guess, each person should have its own <strong>unique id</strong>, and <strong>unique username</strong>. Your task is to implement these functions and test them.</p>
<h3>Constraints</h3>
<p>Database should have methods:</p>
<ul>
<li>Add
<ul>
<li>If there are already users with this username, throw</li>
<li>If there are already users with this id, throw</li>
</ul>
</li>
<li>Remove</li>
<li>FindByUsername
<ul>
<li>If no user is present by this username, throw <strong>InvalidOperationException</strong>.</li>
<li>If username parameter is null, throw</li>
<li>Arguments are all CaseSensitive!</li>
</ul>
</li>
<li>FindById
<ul>
<li>If no user is present by this id, throw <strong>InvalidOperationException</strong>.</li>
<li>If negative ids are found, throw <strong>ArgumentOutOfRangeException</strong>.</li>
</ul>
</li>
</ul>
<h3>Hint</h3>
<p>Do not forget to test the constructor(s). They are methods too!</p>
<h2>Problem 3.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Iterator Test</h2>
<p>Create a class "ListIterator", it should receive the collection (strings) which it will iterate, through its constructor. You should store the elements in a List and get them initially through its constructor. If there is null passed to the constructor, throw new <strong>ArgumentNullException</strong>. The class should have three main functions:</p>
<ul>
<li><strong>Move</strong> - should move an internal index position to the next index in the list, the method should return true if it successfully moved and false if there is no next index.</li>
<li><strong>HasNext</strong> - should return true if there is a next index and false if the index is already at the last element of the list.</li>
<li><strong>Print</strong> - should print the element at the current internal index, calling Print on a collection without elements should throw an appropriate exception with the message "<strong>Invalid Operation!</strong>".</li>
</ul>
<p>By default, the internal index should be pointing to the <strong>0<sup>th</sup> index</strong> of the List. Your program should support the following commands:</p>
<table width="1382">
<tbody>
<tr>
<td width="331">
<p><strong>Command</strong></p>
</td>
<td width="435">
<p><strong>Return Type</strong></p>
</td>
<td width="616">
<p><strong>Description</strong></p>
</td>
</tr>
<tr>
<td width="331">
<p>Move</p>
</td>
<td width="435">
<p>boolean</p>
</td>
<td width="616">
<p>This command should move the internal index to the next index.</p>
</td>
</tr>
<tr>
<td width="331">
<p>Print</p>
</td>
<td width="435">
<p>void</p>
</td>
<td width="616">
<p>This command should return the element at the current internal index.</p>
</td>
</tr>
<tr>
<td width="331">
<p>HasNext</p>
</td>
<td width="435">
<p>boolean</p>
</td>
<td width="616">
<p>Returns whether the collection has a next element.</p>
</td>
</tr>
</tbody>
</table>
<h3>Test</h3>
<p>Create tests, so you are sure all methods in the class ListIterator are working as intended.</p>
<h3>Constraints</h3>
<ul>
<li>There will always be only <strong>1</strong> <strong>Create</strong> command and it will always be the first command passed.</li>
<li>The last command will always be the only <strong>END</strong></li>
</ul>
<h3>Examples</h3>
<table width="1390">
<tbody>
<tr>
<td width="521">
<p><strong>Input</strong></p>
</td>
<td width="869">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="521">
<p>Create</p>
<p>Print</p>
<p>END</p>
</td>
<td width="869">
<p>Invalid Operation!</p>
</td>
</tr>
<tr>
<td width="521">
<p>Create Stefcho Goshky</p>
<p>HasNext</p>
<p>Print</p>
<p>Move</p>
<p>Print</p>
<p>END</p>
</td>
<td width="869">
<p>True</p>
<p>Stefcho</p>
<p>True</p>
<p>Goshky</p>
</td>
</tr>
<tr>
<td width="521">
<p>Create 1 2 3</p>
<p>HasNext</p>
<p>Move</p>
<p>HasNext</p>
<p>HasNext</p>
<p>Move</p>
<p>HasNext</p>
<p>END</p>
</td>
<td width="869">
<p>True</p>
<p>True</p>
<p>True</p>
<p>True</p>
<p>True</p>
<p>False</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 4.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; **Bubble Sort Test</h2>
<p>There is a sorting algorithm - Bubble Sort. You could read this article, to get better the idea: <a href="https://en.wikipedia.org/wiki/Bubble_sort#Analysis">Bubble Sort</a>.</p>
<p><strong>Bubble sort</strong>, sometimes referred to as&nbsp;<strong>sinking sort</strong>, is a simple&nbsp;<a href="https://en.wikipedia.org/wiki/Sorting_algorithm">sorting algorithm</a>&nbsp;that repeatedly steps through the list to be sorted, compares each pair of adjacent items and&nbsp;<a href="https://en.wikipedia.org/wiki/Swap_(computer_science)">swaps</a>&nbsp;them if they are in the wrong order. The pass through the list is repeated until no swaps are needed, which indicates that the list is sorted. The algorithm, which is a&nbsp;<a href="https://en.wikipedia.org/wiki/Comparison_sort">comparison sort</a>, is named for the way smaller elements "bubble" to the top of the list. Although the algorithm is simple, it is too slow and impractical for most problems even when compared to&nbsp;<a href="https://en.wikipedia.org/wiki/Insertion_sort">insertion sort</a>.&nbsp;It can be practical if the input is usually in sorted order but may occasionally have some out-of-order elements nearly in position.</p>
<p>Create a class "Bubble", and try to implement the sorting method yourslef. Create a Test class and test, is it working as intended. Think about the border cases.</p>