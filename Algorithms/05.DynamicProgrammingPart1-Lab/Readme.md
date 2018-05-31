<h1>Lab: Dynamic Programming</h1>
<p>This document defines the <strong>in-class exercises</strong> (lab) for the <a href="https://softuni.bg/opencourses/algorithms">"Algortihms" course @ Software University</a>.</p>
<h2>1.&nbsp;&nbsp; Fibonacci</h2>
<p>Write a <strong>dynamic programming</strong> solution for finding n<sup>th</sup> Fibonacci member.</p>
<ul>
<li>F<sub>0</sub> = 0</li>
<li>F<sub>1</sub> = 1</li>
<li>F<sub>2</sub> = 2</li>
</ul>
<h3>Examples</h3>
<table width="227">
<tbody>
<tr>
<td width="103">
<p><strong>Input</strong></p>
</td>
<td width="125">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="103">
<p>2</p>
</td>
<td width="125">
<p>1</p>
</td>
</tr>
<tr>
<td width="103">
<p>5</p>
</td>
<td width="125">
<p>5</p>
</td>
</tr>
<tr>
<td width="103">
<p>20</p>
</td>
<td width="125">
<p>6765</p>
</td>
</tr>
</tbody>
</table>
<h2>2.&nbsp;&nbsp; Longest Increasing Subsequence</h2>
<p>Let&rsquo;s have a sequence of numbers <strong>S = {a<sub>1</sub>, a<sub>2</sub>, &hellip; a<sub>n</sub>}</strong>. An <strong>increasing</strong> subsequence is a sequence of numbers within S where each number is <strong>larger</strong> than the previous. We <strong>do not change the relative positions</strong> of the numbers, e.g. we do not move smaller elements to the left to obtain longer sequences. If several sequences with equal length exist, find the left-most of them</p>
<h3>Examples</h3>
<table width="384">
<tbody>
<tr>
<td width="232">
<p><strong>Input</strong></p>
</td>
<td width="152">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="232">
<p>1 2 5 3 4</p>
</td>
<td width="152">
<p>1 2 3 4</p>
</td>
</tr>
<tr>
<td width="232">
<p>4 3 2 1</p>
</td>
<td width="152">
<p>4</p>
</td>
</tr>
<tr>
<td width="232">
<p>4 2 -1 3 5 5</p>
</td>
<td width="152">
<p>2 3 5</p>
</td>
</tr>
</tbody>
</table>
<h3>Solution</h3>
<h3>Dynamic Programming Approach</h3>
<p>The LIS problem can be solved by dividing it into sub-problems &ndash; for each element at <strong>index </strong>i of the <strong>sequence </strong>S, find the LIS in the range [<strong>S<sub>0</sub></strong> &hellip; <strong>S<sub>i</sub></strong>].</p>
<p>Example for S = { 3, 14, 5, 12, 15, 7, 8, 9, 11, 10, 1 }:</p>
<ul>
<li>LIS { 3 } =&gt; { 3 }</li>
<li>LIS { 3, 14 } =&gt; { 3, 14 }</li>
<li>LIS { 3, 14, 5 } =&gt; { 3, 5 }</li>
<li>LIS { 3, 14, 5, 12 } =&gt; { 3, 5, 12 }</li>
<li></li>
</ul>
<p>For each index, we&rsquo;ll <strong>keep track of the length of the LIS up to that index</strong> and the <strong>previous index</strong> of the LIS. E.g., the length of the LIS at index <strong>5</strong> is <strong>3</strong>, the longest sequence ending in seq[5] is {3, 5, 7} and the index of the previous element of the subsequence (the number 5) is 2. The table below illustrates these computations:</p>
<table width="1400">
<tbody>
<tr>
<td width="128">
<p>index</p>
</td>
<td width="60">
<p>0</p>
</td>
<td width="94">
<p>1</p>
</td>
<td width="81">
<p>2</p>
</td>
<td width="114">
<p>3</p>
</td>
<td width="149">
<p>4</p>
</td>
<td width="102">
<p>5</p>
</td>
<td width="121">
<p>6</p>
</td>
<td width="141">
<p>7</p>
</td>
<td width="173">
<p>8</p>
</td>
<td width="173">
<p>9</p>
</td>
<td width="65">
<p>10</p>
</td>
</tr>
<tr>
<td width="128">
<p>S[]</p>
</td>
<td width="60">
<p><strong>3</strong></p>
</td>
<td width="94">
<p><strong>14</strong></p>
</td>
<td width="81">
<p><strong>5</strong></p>
</td>
<td width="114">
<p><strong>12</strong></p>
</td>
<td width="149">
<p><strong>15</strong></p>
</td>
<td width="102">
<p><strong>7</strong></p>
</td>
<td width="121">
<p><strong>8</strong></p>
</td>
<td width="141">
<p><strong>9</strong></p>
</td>
<td width="173">
<p><strong>11</strong></p>
</td>
<td width="173">
<p><strong>10</strong></p>
</td>
<td width="65">
<p><strong>1</strong></p>
</td>
</tr>
<tr>
<td width="128">
<p>len[]</p>
</td>
<td width="60">
<p>1</p>
</td>
<td width="94">
<p>2</p>
</td>
<td width="81">
<p>2</p>
</td>
<td width="114">
<p>3</p>
</td>
<td width="149">
<p>4</p>
</td>
<td width="102">
<p>3</p>
</td>
<td width="121">
<p>4</p>
</td>
<td width="141">
<p>5</p>
</td>
<td width="173">
<p>6</p>
</td>
<td width="173">
<p>6</p>
</td>
<td width="65">
<p>1</p>
</td>
</tr>
<tr>
<td width="128">
<p>prev[]</p>
</td>
<td width="60">
<p>-1</p>
</td>
<td width="94">
<p>0</p>
</td>
<td width="81">
<p>0</p>
</td>
<td width="114">
<p>2</p>
</td>
<td width="149">
<p>3</p>
</td>
<td width="102">
<p>2</p>
</td>
<td width="121">
<p>5</p>
</td>
<td width="141">
<p>6</p>
</td>
<td width="173">
<p>7</p>
</td>
<td width="173">
<p>7</p>
</td>
<td width="65">
<p>-1</p>
</td>
</tr>
<tr>
<td width="128">
<p>LIS</p>
</td>
<td width="60">
<p>{3}</p>
</td>
<td width="94">
<p>{3,14}</p>
</td>
<td width="81">
<p>{3,5}</p>
</td>
<td width="114">
<p>{3,5,12}</p>
</td>
<td width="149">
<p>{3,5,12,15}</p>
</td>
<td width="102">
<p>{3,5,7}</p>
</td>
<td width="121">
<p>{3,5,7,8}</p>
</td>
<td width="141">
<p>{3,5,7,8,9}</p>
</td>
<td width="173">
<p>{3,5,7,8,9,11}</p>
</td>
<td width="173">
<p>{3,5,7,8,9,10}</p>
</td>
<td width="65">
<p>{1}</p>
</td>
</tr>
</tbody>
</table>
<p>We need to calculate the info in the above table for every element of the original sequence S, so we&rsquo;ll need two additional arrays with length equal to the length of S. Translating this into code within our method, we get:</p>
<p>We also need to keep track of the <strong>length of the longest subsequence</strong> found so far and the index at which it ends (we&rsquo;ll use <strong>-1</strong> to mark that there is no such index found currently):</p>
<h3>Calculate LIS at Each Index</h3>
<p>To obtain the longest increasing sequence up to a given index, we just have to find the LIS up to that point to which the current element can be appended as the largest. That is why, when considering the sequence {3, 14, 5} we obtained {3, 5}; we want to know the longest sequence in which the current number (5) participates.</p>
<p>We&rsquo;ll do the following:</p>
<ul>
<li>loop through each number in the sequence;</li>
<li>find the longest sequence up to that point which ends with a number which is smaller than the current.</li>
</ul>
<p>Remember that we keep track of the length of each LIS in the len[] array.</p>
<p>Don&rsquo;t forget to keep track of the length of the longest increasing subsequence and the index of its last element:</p>
<h3>Recover the LIS by Walking through prev[]</h3>
<p>Knowing the index of the last element of the LIS, we can get the whole sequence by continuously taking each previous element using the info we keep in the prev[] array. Store the elements in a list, reverse it and return it:</p>
<h3>Remove the Hardcoded Values</h3>
<p>The solution is now ready, but the program currently works on a hardcoded array. Just read the numbers from the console and you&rsquo;re done!</p>
<h2>3.&nbsp;&nbsp; Move Down/Right</h2>
<p>Given a <strong>matrix of N by M</strong> cells filled with positive integers, find the path from <strong>top left </strong>to <strong>bottom right</strong> with a <strong>highest sum </strong>of cells by moving only down or right.</p>
<h3>Examples</h3>
<table width="965">
<tbody>
<tr>
<td width="152">
<p><strong>Input</strong></p>
</td>
<td width="813">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="152">
<p>4</p>
<p>4</p>
<p>1 3 2 1</p>
<p>5 3 2 1</p>
<p>1 7 3 1</p>
<p>1 3 1 1</p>
</td>
<td width="813">
<p>[0, 0] [1, 0] [1, 1] [2, 1] [3, 1] [3, 2] [3, 3]</p>
</td>
</tr>
<tr>
<td width="152">
<p>3</p>
<p>3</p>
<p>1 1 1</p>
<p>1 1 1</p>
<p>1 1 1</p>
</td>
<td width="813">
<p>[0, 0] [1, 0] [2, 0] [2, 1] [2, 2]</p>
</td>
</tr>
<tr>
<td width="152">
<p>3</p>
<p>3</p>
<p>1 0 6</p>
<p>8 3 7</p>
<p>2 4 9</p>
</td>
<td width="813">
<p>[0, 0] [1, 0] [1, 1] [1, 2] [2, 2]</p>
</td>
</tr>
</tbody>
</table>
<h2>4.&nbsp;&nbsp; Rod Cutting</h2>
<p>Find the best way to cut up a rod with a specified length. You are also given to prices of all possible lengths starting from 0.</p>
<h3>Examples</h3>
<table width="599">
<tbody>
<tr>
<td width="474">
<p><strong>Input</strong></p>
</td>
<td width="125">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="474">
<p>0 1 5 8 9 10 17 17 20 24 30</p>
<p>4</p>
</td>
<td width="125">
<p>10</p>
<p>2 2</p>
</td>
</tr>
<tr>
<td width="474">
<p>0 1 5 8 9 10 17 17 20 24 30</p>
<p>8</p>
</td>
<td width="125">
<p>22</p>
<p>2 6</p>
</td>
</tr>
<tr>
<td width="474">
<p>0 1 5 8 9 10 17 17 20 24 30</p>
<p>10</p>
</td>
<td width="125">
<p>30</p>
<p>10</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>