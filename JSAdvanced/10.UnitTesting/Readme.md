<h1>Lab: Unit Testing and Error Handling</h1>
<p>Problems for in-class lab for the <a href="https://softuni.bg/courses/javascript-advanced">&ldquo;JavaScript Advanced&rdquo; course @ SoftUni</a>. Submit your solutions in the SoftUni judge system at <a href="https://judge.softuni.bg/Contests/307/">https://judge.softuni.bg/Contests/307/</a>.</p>
<h1>Error Handling</h1>
<h2>1.&nbsp;&nbsp; Sub Sum</h2>
<p>Write a JS function to sum a <strong>range</strong> of numeric elements from array. The function takes three parameters &ndash; the first is an <strong>array</strong>, the second is <strong>start index</strong> and the third is an <strong>end index</strong>. Both indexes are <strong>inclusive</strong>. Assume array elements may not be of type Number and cast everything. Implement the following error handling:</p>
<ul>
<li>if the <strong>first element</strong> is not an array, return NaN</li>
<li>if the <strong>start index</strong> is less than zero, assume it is zero</li>
<li>if the <strong>end index</strong> is outside the bounds of the array, assume it points to the last index of the array</li>
</ul>
<h3>Input / Output</h3>
<p>Your function must take three <strong>parameters</strong>. As output, <strong>return</strong> the resulting <strong>sum</strong> as instructed.</p>
<h3>Examples</h3>
<table width="1361">
<tbody>
<tr>
<td width="831">
<p>Sample Input</p>
</td>
<td width="529">
<p>Sample Output</p>
</td>
</tr>
<tr>
<td width="831">
<p>subsum([10, 20, 30, 40, 50, 60], 3, 300)</p>
</td>
<td width="529">
<p>150</p>
</td>
</tr>
<tr>
<td width="831">
<p>subsum([1.1, 2.2, 3.3, 4.4, 5.5], -3, 1)</p>
</td>
<td width="529">
<p>3.3</p>
</td>
</tr>
<tr>
<td width="831">
<p>subsum([10, 'twenty', 30, 40], 0, 2)</p>
</td>
<td width="529">
<p>NaN</p>
</td>
</tr>
<tr>
<td width="831">
<p>subsum([], 1, 2)</p>
</td>
<td width="529">
<p>0</p>
</td>
</tr>
<tr>
<td width="831">
<p>subsum('text', 0, 2)</p>
</td>
<td width="529">
<p>NaN</p>
</td>
</tr>
</tbody>
</table>
<h2>2.&nbsp;&nbsp; Playing Cards</h2>
<p>Create a JS <strong>factory function</strong> that returns a <strong>Card</strong> object to hold a card&rsquo;s face and suit, both set trough the constructor. <strong>Throw</strong> an error if the card is initialized with invalid <strong>face</strong> or <strong>suit</strong> or if an attempt is made to change the <strong>face</strong> or <strong>suit</strong> of an existing instance to an invalid value.</p>
<ul>
<li>Valid card faces are: 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A</li>
<li>Valid card suits are: S (&spades;), H (&hearts;), D (&diams;), C (&clubs;)</li>
</ul>
<p>Both face and suit are expected as an uppercase string. The class also needs to have a toString() method that prints the card&rsquo;s face and suit as a string. Use the following UTF code literals to represent the suits:</p>
<ul>
<li>\u2660 &ndash; Spades (&spades;)</li>
<li>\u2665 &ndash; Hearts (&hearts;)</li>
<li>\u2666 &ndash; Diamonds (&diams;)</li>
<li>\u2663 &ndash; Clubs (&clubs;)</li>
</ul>
<h3>Input / Output</h3>
<p>The factory function must take two string parameters. The toString() method of the returned object must return a string.</p>
<p>Submit the factory function.</p>
<h3>Examples</h3>
<table width="1361">
<tbody>
<tr>
<td width="983">
<p>Sample Input</p>
</td>
<td width="378">
<p>Sample Output</p>
</td>
</tr>
<tr>
<td width="983">
<p>console.log('' + makeCard('A', 'S'));</p>
</td>
<td width="378">
<p>A&spades;</p>
</td>
</tr>
<tr>
<td width="983">
<p>console.log('' + makeCard('10', 'H'));</p>
</td>
<td width="378">
<p>10&hearts;</p>
</td>
</tr>
<tr>
<td width="983">
<p>console.log('' + makeCard('1', 'C'));</p>
</td>
<td width="378">
<p>Error</p>
</td>
</tr>
</tbody>
</table>
<h2>3.&nbsp;&nbsp; Deck of Cards</h2>
<p>Write a JS function that takes a deck of cards as a string array and prints them as a sequence of cards (space separated). Print "Invalid card: [card]" when an invalid card definition is passed as input. Use the solution from the previous task to generate the cards.</p>
<h3>Input / Output</h3>
<p>The function must take an array of strings as parameter. As output, print on the console the list of cards as strings, separated by space.</p>
<p>Submit a function that contains the makeCard factory function and other logic.</p>
<table width="1361">
<tbody>
<tr>
<td width="1361">
<p>deck.js</p>
</td>
</tr>
<tr>
<td width="1361">
<p>function printDeckOfCards(cards) {</p>
<p>&nbsp; function makeCard {</p>
<p>&nbsp;&nbsp;&nbsp; <em>// TODO use function definition from previous task</em></p>
<p>&nbsp; }</p>
<p>&nbsp;</p>
<p>&nbsp; <em>// TODO process input</em></p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<h3>Examples</h3>
<table width="1361">
<tbody>
<tr>
<td width="831">
<p>Sample Input</p>
</td>
<td width="529">
<p>Sample Output</p>
</td>
</tr>
<tr>
<td width="831">
<p>printDeckOfCards(['AS', '10D', 'KH', '2C']);</p>
</td>
<td width="529">
<p>A&spades; 10&diams; K&hearts; 2&clubs;</p>
</td>
</tr>
<tr>
<td width="831">
<p>printDeckOfCards(['5S', '3D', 'QD', '1C']);</p>
</td>
<td width="529">
<p>Invalid card: 1C</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
<h1>Unit Testing</h1>
<p>The Unit Tests with Sinon and Mocha strategy gives you access to the following libraries to help you test your code - Mocha, Sinon, Chai, Sinon-Chai and jQuery.</p>
<p>You are required to <strong>only submit the unit tests</strong> for the object/function you are testing. The strategy provides access to Chai's <strong>expect</strong>, <strong>assert</strong> and <strong>should</strong> methods and jQuery.</p>
<h3>Example Submission</h3>
<p>&nbsp;</p>
<p>&nbsp;</p>
<h2>4.&nbsp;&nbsp; Sum of Numbers</h2>
<p>Write Mocha tests to check the functionality of the following JS code:</p>
<table width="1361">
<tbody>
<tr>
<td width="1361">
<p>rgb-to-hex.js</p>
</td>
</tr>
<tr>
<td width="1361">
<p><strong>function </strong><em>sum</em>(arr) {<br /> &nbsp;&nbsp;&nbsp; <strong>let </strong>sum = 0;<br /> &nbsp;&nbsp;&nbsp; <strong>for </strong>(num <strong>of </strong>arr)<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; sum += Number(num);<br /> &nbsp;&nbsp;&nbsp; <strong>return </strong>sum;<br /> }</p>
</td>
</tr>
</tbody>
</table>
<p>Your tests will be supplied a function named 'sum'. It needs to meet the following requirements:</p>
<ul>
<li>Takes and <strong>array</strong> of <strong>numbers</strong> as argument</li>
<li><strong>Returns</strong> the <strong>sum</strong> of the values of all elements inside the array</li>
</ul>
<h2>5.&nbsp;&nbsp; Check for Symmetry</h2>
<p>Write Mocha tests to check the functionality of the following JS code:</p>
<table width="1361">
<tbody>
<tr>
<td width="1361">
<p>rgb-to-hex.js</p>
</td>
</tr>
<tr>
<td width="1361">
<p><strong>function </strong><em>isSymmetric</em>(arr) {<br /> &nbsp;&nbsp;&nbsp; <strong>if </strong>(!Array.isArray(arr))<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>return false</strong>; <em>// Non-arrays are non-symmetric<br /> &nbsp;&nbsp;&nbsp; </em><strong>let </strong>reversed = arr.slice(0).reverse(); <em>// Clone and reverse<br /> &nbsp;&nbsp;&nbsp; </em><strong>let </strong>equal = (JSON.stringify(arr) == JSON.stringify(reversed));<br /> &nbsp;&nbsp;&nbsp; <strong>return </strong>equal;<br /> }</p>
</td>
</tr>
</tbody>
</table>
<p>Your tests will be supplied a function named 'isSymmetric'. It needs to meet the following requirements:</p>
<ul>
<li>Takes and <strong>array</strong> as argument</li>
<li><strong>Returns</strong> <strong>false</strong> for any input that isn&rsquo;t of the <strong>correct type</strong></li>
<li><strong>Returns</strong> <strong>true</strong> if the input array is <strong>symmetric</strong> (first half is the same as the second half mirrored)</li>
<li>Otherwise, returns <strong>false</strong></li>
</ul>
<h2>6.&nbsp;&nbsp; RGB to Hex</h2>
<p>Write Mocha tests to check the functionality of the following JS code:</p>
<table width="1361">
<tbody>
<tr>
<td width="1361">
<p>rgb-to-hex.js</p>
</td>
</tr>
<tr>
<td width="1361">
<p><strong>function </strong><em>rgbToHexColor</em>(red, green, blue) {<br /> &nbsp;&nbsp;&nbsp; <strong>if </strong>(!Number.isInteger(red) || (red &lt; 0) || (red &gt; 255))<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>return </strong>undefined; <em>// Red value is invalid<br /> &nbsp;&nbsp;&nbsp; </em><strong>if </strong>(!Number.isInteger(green) || (green &lt; 0) || (green &gt; 255))<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>return </strong>undefined; <em>// Green value is invalid<br /> &nbsp;&nbsp;&nbsp; </em><strong>if </strong>(!Number.isInteger(blue) || (blue &lt; 0) || (blue &gt; 255))<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>return </strong>undefined; <em>// Blue value is invalid<br /> &nbsp;&nbsp;&nbsp; </em><strong>return </strong><strong>"#" </strong>+<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; (<strong>"0" </strong>+ red.toString(16).toUpperCase()).slice(-2) +<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; (<strong>"0" </strong>+ green.toString(16).toUpperCase()).slice(-2) +<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; (<strong>"0" </strong>+ blue.toString(16).toUpperCase()).slice(-2);<br /> }</p>
</td>
</tr>
</tbody>
</table>
<p>Your tests will be supplied a function named 'rgbToHexColor', which takes three arguments. It needs to meet the following requirements:</p>
<ul>
<li>Takes three <strong>integer numbers</strong>, representing the red, green and blue values of an RGB color, each <strong>within range [0&hellip;255]</strong></li>
<li><strong>Returns</strong> the same color in hexadecimal format as a <strong>string</strong> (e.g. '#FF9EAA')</li>
<li><strong>Returns</strong> 'undefined' if <strong>any</strong> of the input parameters are of <strong>invalid type</strong> or not in the expected <strong>range</strong></li>
</ul>
<h2>7.&nbsp;&nbsp; Add / Subtract</h2>
<p>Write Mocha tests to check the functionality of the following JS code:</p>
<table width="1361">
<tbody>
<tr>
<td width="1361">
<p>rgb-to-hex.js</p>
</td>
</tr>
<tr>
<td width="1361">
<p><strong>function </strong><em>createCalculator</em>() {<br /> &nbsp;&nbsp;&nbsp; <strong>let </strong>value = 0;<br /> &nbsp;&nbsp;&nbsp; <strong>return </strong>{<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; add: <strong>function</strong>(num) { value += Number(num); },<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; subtract: <strong>function</strong>(num) { value -= Number(num); },<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; get: <strong>function</strong>() { <strong>return </strong>value; }<br /> &nbsp;&nbsp;&nbsp; }<br /> }</p>
</td>
</tr>
</tbody>
</table>
<p>Your tests will be supplied a function named 'createCalculator'. It needs to meet the following requirements:</p>
<ul>
<li><strong>Returns</strong> a <strong>module</strong> (object), containing the functions add, subtract and get as <strong>properties</strong></li>
<li>Keeps an <strong>internal sum</strong> which <strong>can&rsquo;t be modified</strong> from the outside</li>
<li>The functions add and subtract take a parameter that can be parsed as a number (either a number or a string containing a number) that is added or subtracted from the <strong>internal sum</strong></li>
<li>The function get <strong>returns</strong> the value of the <strong>internal sum</strong></li>
</ul>