<h1>Lab: Combinatorial Algorithms</h1>
<p>This document defines the <strong>in-class exercises</strong> (lab) for the <a href="https://softuni.bg/opencourses/algorithms">"Algortihms" course @ Software University</a>.</p>
<h1>Part I - Permutations</h1>
<h2>1.&nbsp;&nbsp; Permutations without Repetitions</h2>
<p>Given a set of elements, find all permutations without repetitions.</p>
<h3>Examples</h3>
<table width="244">
<tbody>
<tr>
<td width="119">
<p><strong>Input</strong></p>
</td>
<td width="125">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="119">
<p>A B C</p>
</td>
<td width="125">
<p>A B C</p>
<p>A C B</p>
<p>B A C</p>
<p>B C A</p>
<p>C B A</p>
<p>C A B</p>
</td>
</tr>
</tbody>
</table>
<h2>2.&nbsp;&nbsp; Permutations with Repetitions</h2>
<p>Given a multi-set of elements, find all permutations.</p>
<h3>Examples</h3>
<table width="244">
<tbody>
<tr>
<td width="119">
<p><strong>Input</strong></p>
</td>
<td width="125">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="119">
<p>A B B</p>
</td>
<td width="125">
<p>A B B</p>
<p>B A B</p>
<p>B B A</p>
</td>
</tr>
</tbody>
</table>
<h1>Part II - Variations</h1>
<h2>3.&nbsp;&nbsp; Variations without Repetitions</h2>
<p>Given a set of elements, find all variations of k elements without repetitions.</p>
<h3>Examples</h3>
<table width="244">
<tbody>
<tr>
<td width="119">
<p><strong>Input</strong></p>
</td>
<td width="125">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="119">
<p>A B C</p>
<p>2</p>
</td>
<td width="125">
<p>A B</p>
<p>A C</p>
<p>B A</p>
<p>B C</p>
<p>C A</p>
<p>C B</p>
</td>
</tr>
</tbody>
</table>
<h2>4.&nbsp;&nbsp; Variations with Repetition</h2>
<p>Given a set of elements, find all variations of k elements with repetitions.</p>
<h3>Examples</h3>
<table width="244">
<tbody>
<tr>
<td width="119">
<p><strong>Input</strong></p>
</td>
<td width="125">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="119">
<p>A B C</p>
<p>2</p>
</td>
<td width="125">
<p>A A</p>
<p>A B</p>
<p>A C</p>
<p>B A</p>
<p>B B</p>
<p>B C</p>
<p>C A</p>
<p>C B</p>
<p>C C</p>
</td>
</tr>
</tbody>
</table>
<h1>Part III - Combinations</h1>
<h2>5.&nbsp;&nbsp; Combinations without Repetition</h2>
<p>Given a set of elements, generate all combinations of k elements without repetition.</p>
<h3>Examples</h3>
<table width="244">
<tbody>
<tr>
<td width="119">
<p><strong>Input</strong></p>
</td>
<td width="125">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="119">
<p>A B C</p>
<p>2</p>
</td>
<td width="125">
<p>A B</p>
<p>A C</p>
<p>B C</p>
</td>
</tr>
</tbody>
</table>
<h2>6.&nbsp;&nbsp; Combinations with Repetition</h2>
<p>Given a set of elements, generate all combinations of k elements with repetition.</p>
<h3>Examples</h3>
<table width="244">
<tbody>
<tr>
<td width="119">
<p><strong>Input</strong></p>
</td>
<td width="125">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="119">
<p>A B C</p>
<p>2</p>
</td>
<td width="125">
<p>A A</p>
<p>A B</p>
<p>A C</p>
<p>B B</p>
<p>B C</p>
<p>C C</p>
</td>
</tr>
</tbody>
</table>
<h1>Part IV - Binomial Coefficients</h1>
<h2>7.&nbsp;&nbsp; N Choose K Count</h2>
<p>Given a <strong>n</strong> and <strong>k</strong>, calculate the number of possible <strong>n choose k</strong> combinations (without repetition).</p>
<h3>Examples</h3>
<table width="270">
<tbody>
<tr>
<td width="103">
<p><strong>Input</strong></p>
</td>
<td width="168">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="103">
<p>3</p>
<p>2</p>
</td>
<td width="168">
<p>3</p>
</td>
</tr>
<tr>
<td width="103">
<p>49</p>
<p>6</p>
</td>
<td width="168">
<p>13983816</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>