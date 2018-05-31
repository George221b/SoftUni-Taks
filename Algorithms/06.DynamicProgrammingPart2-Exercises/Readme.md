<h1>Homework: Dynamic Programming</h1>
<p>This document defines the <strong>homework assignments</strong> for the <a href="https://softuni.bg/opencourses/algorithms">"Algortihms" course @ Software University</a>. Please submit a single zip / rar / 7z archive holding the solutions (source code) of all below described problems.</p>
<h2>1.&nbsp;&nbsp; Connecting Cables</h2>
<p>We are in a rectangular room. On opposite sides of the room there are sets of n cables (n &lt; 1000). The cables are indexed from 1 to n.</p>
<p>On each side of the room there is a permutation of the cables, e.g. on one side we always have ordered {1, 2, 3, 4, 5} and on the other side we have some permutation {5, 1, 3, 4, 2}. We are trying to connect each cable from one side with the corresponding cable on the other side &ndash; connect 1 with 1, 2 with 2, etc. <strong>Cables are straight and should not overlap!</strong></p>
<p>The task is to find the maximum number of pairs we can connect given the restrictions above.</p>
<p>Examples</p>
<table width="1397">
<tbody>
<tr>
<td width="378">
<p><strong>Input</strong></p>
</td>
<td width="453">
<p><strong>Output</strong></p>
</td>
<td width="566">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="378">
<p>2 5 3 8 7 4 6 9 1</p>
</td>
<td width="453">
<p>Maximum pairs connected: 5</p>
</td>
<td width="566">&nbsp;</td>
</tr>
<tr>
<td width="378">
<p>4 3 2 1</p>
</td>
<td width="453">
<p>Maximum pairs connected: 1</p>
</td>
<td width="566">
<p>Any other pair can be conntected as well.</p>
</td>
</tr>
<tr>
<td width="378">
<p>1 2 3</p>
</td>
<td width="453">
<p>Maximum pairs connected: 3</p>
</td>
<td width="566">
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<h2>2.&nbsp;&nbsp; Minimum Edit Distance</h2>
<p>We have two strings, s1 and s2. The goal is to obtain s2 from s1 by applying the following operations:</p>
<ul>
<li>replace(i, x) &ndash; in s1, replaces the symbol at index i with the character x</li>
<li>insert(i, x) &ndash; in s1, inserts the character x at index i</li>
<li>delete(i) &ndash; from s1, removes the character at index i</li>
</ul>
<p>We are only allowed to modify s1, s2 stays unchanged at all times. Each of the three operations has a certain <strong>cost</strong> associated with it (positive integer number). <strong>Note</strong>: the cost of the replace(i, x) operation is 0 if it doesn&rsquo;t actually change the character.</p>
<p>The goal is to find the sequence of operations which will produce s2 from s1 with <strong>minimal cost</strong>.</p>
<p>Examples</p>
<table width="1400">
<tbody>
<tr>
<td width="297">
<p><strong>Input</strong></p>
</td>
<td width="426">
<p><strong>Output</strong></p>
</td>
<td width="677">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="297">
<p>cost-replace = 3</p>
<p>cost-insert = 2</p>
<p>cost-delete = 1</p>
<p>s1 = abracadabra</p>
<p>s2 = mabragabra</p>
</td>
<td width="426">
<p>Minimum edit distance: 7</p>
<p>INSERT(0, m)</p>
<p>DELETE(3)</p>
<p>DELETE(4)</p>
<p>REPLACE(6, g)</p>
</td>
<td width="677">
<p>Indices refer to the original s1 string &ndash; DELETE(3) deletes the symbol at index 3 from abracadabra, not from the modified string mabracadabra after the INSERT(0, m) operation.</p>
</td>
</tr>
<tr>
<td width="297">
<p>cost-replace = 5</p>
<p>cost-insert = 2</p>
<p>cost-delete = 1</p>
<p>s1 = nqma bira</p>
<p>s2 = ima bira</p>
</td>
<td width="426">
<p>Minimum edit distance: 4</p>
<p>DELETE(0)</p>
<p>DELETE(1)</p>
<p>INSERT(1, i)</p>
</td>
<td width="677">
<p>We can obtain s2 with two operations &ndash; DELETE(0) + REPLACE(1, i), but the cost of the REPLACE operation is high, that&rsquo;s why the solution involves three operations, their total cost is smaller.</p>
<p>The INSERT can be performed also at index 0 and index 2.</p>
</td>
</tr>
<tr>
<td width="297">
<p>cost-replace = 3</p>
<p>cost-insert = 3</p>
<p>cost-delete = 3</p>
<p>s1 = equal</p>
<p>s2 = equal</p>
</td>
<td width="426">
<p>Minimum edit distance: 0</p>
</td>
<td width="677">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="297">
<p>cost-replace = 1</p>
<p>cost-insert = 1</p>
<p>cost-delete = 1</p>
<p>s1 = equal</p>
<p>s2 = different</p>
</td>
<td width="426">
<p>Minimum edit distance: 8</p>
<p>INSERT(0,d)</p>
<p>INSERT(1,i)</p>
<p>INSERT(2,f)</p>
<p>INSERT(3,f)</p>
<p>REPLACE(1,r)</p>
<p>REPLACE(2,e)</p>
<p>REPLACE(3,n)</p>
<p>REPLACE(4,t)</p>
</td>
<td width="677">
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<h2>3.&nbsp;&nbsp; * Symbol Multiplication</h2>
<p>We have an <strong>alphabet</strong> of k symbols (a finite number) and a <strong>multiplication table</strong> showing the result of multiplying each two symbols of the alphabet. E.g., the alphabet is {a, b, c} and the multiplication table is:</p>
<p>This shows that a*a = b, a*b = b, b*a = c, etc. As shown in the example, multiplication is <strong>not commutative or associative</strong> &ndash; a*b != b*a, therefore, the order of multiplication is essential.</p>
<p>We have a string S comprised of characters from the alphabet. The task is to find whether we can obtain the symbol <strong>'a'</strong> by inserting brackets in the string &ndash; all symbols in brackets are multiplied. If so, print the string with the brackets inserted. Print "No solution" otherwise. Assume 'a' will always be in the alphabet.</p>
<p>Examples</p>
<table width="1397">
<tbody>
<tr>
<td width="291">
<p><strong>Input</strong></p>
</td>
<td width="828">
<p><strong>Output</strong></p>
</td>
<td width="278">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="291">
<p>Alphabet = {a,b,c}</p>
<p>Table =</p>
<p>&nbsp; bba</p>
<p>&nbsp; cba</p>
<p>&nbsp; aac</p>
<p>S = abc</p>
</td>
<td width="828">
<p>((a*b)*c)</p>
</td>
<td width="278">
<p>((a*b)*c) = (b*c) = a</p>
</td>
</tr>
<tr>
<td width="291">
<p>Alphabet = {a,b,c}</p>
<p>Table =</p>
<p>&nbsp; bba</p>
<p>&nbsp; cba</p>
<p>&nbsp; aac</p>
<p>S = bacacbcabbbcacab</p>
</td>
<td width="828">
<p>(((b*a)*(c*a))*(((c*(b*c))*a)*((b*((b*b)*(c*a)))*(c*(a*b)))))</p>
</td>
<td width="278">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="291">
<p>Alphabet = {a,b}</p>
<p>Table =</p>
<p>&nbsp; bb</p>
<p>&nbsp; bb</p>
<p>S = abbbaaba</p>
</td>
<td width="828">
<p>No solution</p>
</td>
<td width="278">
<p>No combination of two symbols produces 'a' after multiplication.</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>