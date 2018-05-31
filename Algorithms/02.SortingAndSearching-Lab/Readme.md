<h1>Lab: Sorting and Searching Algorithms</h1>
<p>This document defines the <strong>in-class exercises</strong> assignments for the <a href="https://softuni.bg/trainings/1688/algorithms-july-2017">"Algorithms" course @ Software University</a>.</p>
<h1>Part I &ndash; Sorting</h1>
<ol>
<li><strong>Merge Sort</strong></li>
</ol>
<p>Sort an array of elements using the famous merge sort</p>
<h3>Examples</h3>
<table width="527">
<tbody>
<tr>
<td width="184">
<p><strong>Input</strong></p>
</td>
<td width="343">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="184">
<p>5 4 3 2 1</p>
</td>
<td width="343">
<p>1 2 3 4 5</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>Create your Mergesort generic class with a single Sort method</p>
<p>Create an <strong>auxiliary array</strong> that will help with merging subarrays</p>
<p>Now to implement the Merge() method</p>
<p>As the two subarrays are sorted, if the <strong>largest element in the left</strong> is smaller than the <strong>smallest in the right</strong>, the two subarrays are <strong>already merged</strong></p>
<p>If they are not, however, <strong>transfer all elements to the auxiliary array</strong></p>
<p>Then <strong>merge them back</strong> in the main array</p>
<p>Now to create the recursive Sort() method</p>
<p>If there is <strong>only one element</strong> in the subarray, it is <strong>already sorted</strong></p>
<p>If not, however, you need to <strong>split it into two subarrays</strong>, <strong>sort them recursively</strong> and then <strong>merge them on the way up</strong> of the recursion (as a post-action)</p>
<p>You can now call the Sort() method</p>
<h2>2.&nbsp;&nbsp; Quicksort</h2>
<p>Sort an array of elements using the famous quicksort</p>
<h3>Examples</h3>
<table width="527">
<tbody>
<tr>
<td width="184">
<p><strong>Input</strong></p>
</td>
<td width="343">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="184">
<p>5 4 3 2 1</p>
</td>
<td width="343">
<p>1 2 3 4 5</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>You can learn about the Quicksort algorithm from <a href="https://en.wikipedia.org/wiki/Quicksort">Wikipedia</a>.</p>
<p>A great tool for visualizing the algorithm (along with many others) is available at <a href="http://visualgo.net/sorting.html">Visualgo.net</a>.</p>
<p>The algorithm in short:</p>
<ul>
<li>Quicksort takes unsorted partitions of an array and sorts them</li>
<li>We choose the <strong>pivot</strong>
<ul>
<li>We pick the first element from the unsorted partition and move it in such a way that all smaller elements are on its left and all greater, to its right</li>
</ul>
</li>
<li>With pivot moved to its correct place, we now have two unsorted partitions &ndash; one to the left of it and one to the right</li>
<li><strong>Call the procedure recursively</strong> for each partition</li>
<li>The bottom of the recursion is when a partition has a size of 1, which is by definition sorted</li>
</ul>
<p>First, define the <strong>class</strong> and its <strong>sorting method</strong>:</p>
<p>Now to implement the private Sort() method. Don't forget to handle the <strong>bottom of the recursion</strong></p>
<p>First, find the pivot index and rearange the elements, then sort the left and right partitions recursively:</p>
<p>Now to choose the pivot point.. we need to create a method called Partition()</p>
<p>If there is <strong>only one element</strong>, it is already partitioned and the index of the pivot is the index of its only element</p>
<p>Finding the pivot point involves <strong>rearanging all elements</strong> in the partition so it satisfies the condition <strong>all elements to the reft of the pivot to be smaller</strong> from it, and <strong>all elements to its right to be greater</strong> than it</p>
<h1>Part II &ndash; Implement Binary Search</h1>
<h2>3.&nbsp;&nbsp; Implement Binary Search</h2>
<p>Implement an algorithm that finds the index of an element in a sorted array of integers in logarithmic time</p>
<h3>Examples</h3>
<table width="869">
<tbody>
<tr>
<td width="184">
<p><strong>Input</strong></p>
</td>
<td width="343">
<p><strong>Output</strong></p>
</td>
<td width="343">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="184">
<p>1 2 3 4 5</p>
<p>1</p>
</td>
<td width="343">
<p>0</p>
</td>
<td width="343">
<p>Index of 1 is 0</p>
</td>
</tr>
<tr>
<td width="184">
<p>-1 0 1 2 4</p>
<p>1</p>
</td>
<td width="343">
<p>2</p>
</td>
<td width="343">
<p>Index of 1 is 2</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>First, if you&rsquo;re not familiar with the concept, read about binary search in <a href="https://en.wikipedia.org/wiki/Binary_search_algorithm">Wikipedia</a>.</p>
<p><a href="http://www.dave-reed.com/book/Chapter8/search.html">Here</a> you can find a tool which shows visually how the search is performed.</p>
<p>In short, if we have a <strong>sorted collection</strong> of comparable elements, instead of doing linear search (which takes linear time), we can eliminate half the elements at each step and finish in logarithmic time.</p>
<p>Binary search is a <strong>divide-and-conquer</strong> algorithm; we start at the middle of the collection, if we haven&rsquo;t found the element there, there are three possibilities:</p>
<ul>
<li>The element we&rsquo;re looking for is smaller &ndash; then look to the left of the current element, we know all elements to the right are larger;</li>
<li>The element we&rsquo;re looking for is larger &ndash; look to the right of the current element;</li>
<li>The element is not present, traditionally, return -1 in that case.</li>
</ul>
<p>Start by defining a class with a method</p>
<p>Inside the method, define two variables defining the bounds to be searched and a while loop</p>
<p>Inside the while loop, we need to find the midpoint</p>
<p>If the key is to the left of the midpoint, move the right bound. If the key is to the right of the midpoint, move the left bound</p>
<p>That&rsquo;s it! Good job!</p>