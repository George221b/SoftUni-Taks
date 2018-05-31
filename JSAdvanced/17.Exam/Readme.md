<h1>JS Advanced: Exam 18 March 2018</h1>
<p>Problems for exam preparation for the <a href="https://softuni.bg/courses/javascript-advanced">&ldquo;JavaScript Advanced&rdquo; course @ SoftUni</a>. Submit your solutions in the SoftUni judge system at <a href="https://judge.softuni.bg/Contests/974/">https://judge.softuni.bg/Contests/974/</a>.</p>
<h1>Problem 1. Restaurant Bill (Simple DOM Interaction)</h1>
<p>You are given the following <strong>HTML code</strong>:</p>
<table width="1385">
<tbody>
<tr>
<td width="1385">
<p>restaurant-bill.html</p>
</td>
</tr>
<tr>
<td width="1385">
<p>&lt;!DOCTYPE <strong>html</strong>&gt;</p>
<p>&lt;<strong>html </strong><strong>lang=</strong><strong>"en"</strong>&gt;</p>
<p>&lt;<strong>head</strong>&gt;</p>
<p>&nbsp; &lt;<strong>meta </strong><strong>charset=</strong><strong>"UTF-8"</strong>&gt;</p>
<p>&nbsp; &lt;<strong>title</strong>&gt;Restaurant Bill&lt;/<strong>title</strong>&gt;</p>
<p>&nbsp; &lt;<strong>style</strong>&gt;</p>
<p>&nbsp;&nbsp;&nbsp; <strong>body </strong>{<strong>padding</strong>: 30<strong>px</strong>;}</p>
<p>&nbsp;&nbsp;&nbsp; <strong>table</strong>, <strong>section </strong>{<strong>border</strong>: 1<strong>px solid black</strong>; <strong>border-collapse</strong>: <strong>collapse</strong>;}</p>
<p>&nbsp;&nbsp;&nbsp; <strong>th</strong>, <strong>td </strong>{<strong>padding</strong>: 5<strong>px </strong>20<strong>px</strong>;}</p>
<p>&nbsp;&nbsp;&nbsp; <strong>th</strong>, <strong>tfoot td </strong>{<strong>background</strong>: <strong>#cccccc</strong>;}</p>
<p>&nbsp;&nbsp;&nbsp; <strong>tr</strong>:<strong>nth-child</strong>(<strong>odd</strong>) {<strong>background</strong>: <strong>#eeeeee</strong>;}</p>
<p>&nbsp;&nbsp;&nbsp; <strong>tr</strong>:<strong>nth-child</strong>(<strong>even</strong>) {<strong>background</strong>: <strong>#dddddd</strong>;}</p>
<p>&nbsp;&nbsp;&nbsp; <strong>tfoot </strong>&gt; <strong>tr td </strong>{<strong>font-style</strong>: <strong>italic</strong>; <strong>font-weight</strong>: <strong>bold</strong>;}</p>
<p>&nbsp;&nbsp;&nbsp; <strong>section </strong>{<strong>margin-top</strong>: 10<strong>px</strong>; <strong>width</strong>: 177<strong>px</strong>; <strong>background</strong>: <strong>#cccccc</strong>;}</p>
<p>&nbsp;&nbsp;&nbsp; <strong>section </strong>&gt; <strong>* </strong>{<strong>display</strong>: <strong>block</strong>; <strong>padding</strong>: 5<strong>px</strong>;}</p>
<p>&nbsp;&nbsp;&nbsp; <strong>h3 </strong>{<strong>margin</strong>: 0; <strong>text-align</strong>: <strong>center</strong>;}</p>
<p>&nbsp;&nbsp;&nbsp; <strong>button </strong>{<strong>margin</strong>: 5<strong>px auto</strong>;}</p>
<p>&nbsp; &lt;/<strong>style</strong>&gt;</p>
<p>&nbsp; &lt;<strong>script </strong><strong>src=</strong><strong>"https://code.jquery.com/jquery-3.3.1.min.js"</strong>&gt;&lt;/<strong>script</strong>&gt;</p>
<p>&lt;/<strong>head</strong>&gt;</p>
<p>&lt;<strong>body</strong>&gt;</p>
<p>&lt;<strong>h2</strong>&gt;Restaurant Bill&lt;/<strong>h2</strong>&gt;</p>
<p>&lt;<strong>table </strong><strong>id=</strong><strong>"bill"</strong>&gt;</p>
<p>&nbsp; &lt;<strong>thead</strong>&gt;</p>
<p>&nbsp; &lt;<strong>tr</strong>&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;<strong>th</strong>&gt;Product&lt;/<strong>th</strong>&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;<strong>th</strong>&gt;Price&lt;/<strong>th</strong>&gt;</p>
<p>&nbsp; &lt;/<strong>tr</strong>&gt;</p>
<p>&nbsp; &lt;/<strong>thead</strong>&gt;</p>
<p>&nbsp; &lt;<strong>tbody </strong><strong>id=</strong><strong>"product-list"</strong>&gt;&lt;/<strong>tbody</strong>&gt;</p>
<p>&nbsp; &lt;<strong>tfoot</strong>&gt;</p>
<p>&nbsp; &lt;<strong>tr</strong>&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;<strong>td</strong>&gt;Total:&lt;/<strong>td</strong>&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;<strong>td</strong>&gt;0.00&lt;/<strong>td</strong>&gt;</p>
<p>&nbsp; &lt;/<strong>tr</strong>&gt;</p>
<p>&nbsp; &lt;/<strong>tfoot</strong>&gt;</p>
<p>&lt;/<strong>table</strong>&gt;</p>
<p>&lt;<strong>section </strong><strong>id=</strong><strong>"add-product"</strong>&gt;</p>
<p>&nbsp; &lt;<strong>h3</strong>&gt;Add new product&lt;/<strong>h3</strong>&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;<strong>label</strong>&gt;Product:</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>input </strong><strong>type=</strong><strong>"text"</strong>&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;/<strong>label</strong>&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;<strong>label</strong>&gt;Price:</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>input </strong><strong>type=</strong><strong>"number"</strong>&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;/<strong>label</strong>&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;<strong>button </strong><strong>onclick=</strong><strong>"</strong><em>addProduct</em>()<strong>"</strong>&gt;Add&lt;/<strong>button</strong>&gt;</p>
<p>&lt;/<strong>section</strong>&gt;</p>
<p>&nbsp;</p>
<p>&lt;<strong>script</strong>&gt;</p>
<p>&nbsp; <strong>function </strong><em>addProduct</em>() {</p>
<p>&nbsp;&nbsp;&nbsp; <strong><em>// TODO</em></strong></p>
<p>&nbsp; }</p>
<p>&lt;/<strong>script</strong>&gt;</p>
<p>&nbsp;</p>
<p>&lt;/<strong>body</strong>&gt;</p>
<p>&lt;/<strong>html</strong>&gt;</p>
</td>
</tr>
</tbody>
</table>
<h3>Your Task</h3>
<p><strong>Write the missing JavaScript function </strong>addProduct() to make the <strong>[Add] </strong>button work as expected &ndash; when clicked <strong>adds </strong>the new product&rsquo;s information to the restaurant bill. The <strong>[Add] </strong>button should:</p>
<ul>
<li><strong>Append</strong> the <strong>text</strong> received from the <strong>input boxes </strong>as a <strong>new</strong> <strong>row at the end </strong>of the <strong>table&rsquo;s body</strong></li>
<li><strong>Add </strong>the <strong>new</strong> <strong>product&rsquo;s price</strong> to the <strong>total</strong> sum</li>
<li><strong>Clear </strong>the <strong>input boxes </strong>after the <strong>product&rsquo;s information</strong> is <strong>submitted</strong></li>
<li><strong>Do nothing </strong>if <strong>either</strong> of <strong>text boxes </strong>is <strong>empty</strong></li>
</ul>
<h3>Submission</h3>
<p>Submit only your addProduct function.</p>
<p>&nbsp;</p>
<p><strong><em>Scroll down for examples.</em></strong></p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<h3>Examples</h3>
<p><strong>First example:</strong></p>
<p><strong>Scroll down</strong> for more examples.</p>
<p><strong>&nbsp;</strong></p>
<p><strong>&nbsp;</strong></p>
<p><strong>&nbsp;</strong></p>
<p><strong>&nbsp;</strong></p>
<p><strong>&nbsp;</strong></p>
<p><strong>&nbsp;</strong></p>
<p><strong>&nbsp;</strong></p>
<p><strong>&nbsp;</strong></p>
<p><strong>Second example:</strong></p>
<p>&nbsp;</p>
<p>&nbsp;</p>


<h1>JS Advanced: Exam 18 March 2018</h1>
<p>Problems for exam preparation for the <a href="https://softuni.bg/courses/javascript-advanced">&ldquo;JavaScript Advanced&rdquo; course @ SoftUni</a>. Submit your solutions in the SoftUni judge system at <a href="https://judge.softuni.bg/Contests/974/">https://judge.softuni.bg/Contests/974/</a>.</p>
<h1>Problem 2. Payment Package (Unit Testing)</h1>
<p>You are given the following <strong>JavaScript class</strong>:</p>
<table width="1404">
<tbody>
<tr>
<td width="1404">
<p>PaymentPackage.js</p>
</td>
</tr>
<tr>
<td width="1404">
<p><strong>class </strong>PaymentPackage {<br /> &nbsp; constructor(name, value) {<br /> &nbsp;&nbsp;&nbsp; <strong>this</strong>.name = name;<br /> &nbsp;&nbsp;&nbsp; <strong>this</strong>.value = value;<br /> &nbsp;&nbsp;&nbsp; <strong>this</strong>.VAT = 20;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <em>// Default value&nbsp;&nbsp;&nbsp; <br /> &nbsp;&nbsp;&nbsp; </em><strong>this</strong>.active = <strong>true</strong>; <em>// Default value<br /> &nbsp; </em>}<br /> <br /> &nbsp; <strong>get </strong>name() {<br /> &nbsp;&nbsp;&nbsp; <strong>return this</strong>.<strong>_name</strong>;<br /> &nbsp; }<br /> <br /> &nbsp; <strong>set </strong>name(newValue) {<br /> &nbsp;&nbsp;&nbsp; <strong>if </strong>(<strong>typeof </strong>newValue !== <strong>'string'</strong>) {<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>throw new </strong>Error(<strong>'Name must be a non-empty string'</strong>);<br /> &nbsp;&nbsp;&nbsp; }<br /> &nbsp;&nbsp;&nbsp; <strong>if </strong>(newValue.length === 0) {<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>throw new </strong>Error(<strong>'Name must be a non-empty string'</strong>);<br /> &nbsp;&nbsp;&nbsp; }<br /> &nbsp;&nbsp;&nbsp; <strong>this</strong>.<strong>_name </strong>= newValue;<br /> &nbsp; }<br /> <br /> &nbsp; <strong>get </strong>value() {<br /> &nbsp;&nbsp;&nbsp; <strong>return this</strong>.<strong>_value</strong>;<br /> &nbsp; }<br /> <br /> &nbsp; <strong>set </strong>value(newValue) {<br /> &nbsp;&nbsp;&nbsp; <strong>if </strong>(<strong>typeof </strong>newValue !== <strong>'number'</strong>) {<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>throw new </strong>Error(<strong>'Value must be a non-negative number'</strong>);<br /> &nbsp;&nbsp;&nbsp; }<br /> &nbsp;&nbsp;&nbsp; <strong>if </strong>(newValue &lt; 0) {<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>throw new </strong>Error(<strong>'Value must be a non-negative number'</strong>);<br /> &nbsp;&nbsp;&nbsp; }<br /> &nbsp;&nbsp;&nbsp; <strong>this</strong>.<strong>_value </strong>= newValue;<br /> &nbsp; }<br /> <br /> &nbsp; <strong>get </strong>VAT() {<br /> &nbsp;&nbsp;&nbsp; <strong>return this</strong>.<strong>_VAT</strong>;<br /> &nbsp; }<br /> <br /> &nbsp; <strong>set </strong>VAT(newValue) {<br /> &nbsp;&nbsp;&nbsp; <strong>if </strong>(<strong>typeof </strong>newValue !== <strong>'number'</strong>) {<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>throw new </strong>Error(<strong>'VAT must be a non-negative number'</strong>);<br /> &nbsp;&nbsp;&nbsp; }<br /> &nbsp;&nbsp;&nbsp; <strong>if </strong>(newValue &lt; 0) {<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>throw new </strong>Error(<strong>'VAT must be a non-negative number'</strong>);<br /> &nbsp;&nbsp;&nbsp; }<br /> &nbsp;&nbsp;&nbsp; <strong>this</strong>.<strong>_VAT </strong>= newValue;<br /> &nbsp; }<br /> <br /> &nbsp; <strong>get </strong>active() {<br /> &nbsp;&nbsp;&nbsp; <strong>return this</strong>.<strong>_active</strong>;<br /> &nbsp; }<br /> <br /> &nbsp; <strong>set </strong>active(newValue) {<br /> &nbsp;&nbsp;&nbsp; <strong>if </strong>(<strong>typeof </strong>newValue !== <strong>'boolean'</strong>) {<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>throw new </strong>Error(<strong>'Active status must be a boolean'</strong>);<br /> &nbsp;&nbsp;&nbsp; }<br /> &nbsp;&nbsp;&nbsp; <strong>this</strong>.<strong>_active </strong>= newValue;<br /> &nbsp; }<br /> <br /> &nbsp; toString() {<br /> &nbsp;&nbsp;&nbsp; <strong>const </strong>output = [<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>`Package: </strong>${<strong>this</strong>.name}<strong>` </strong>+ (<strong>this</strong>.active === <strong>false </strong>? <strong>' (inactive)' </strong>: <strong>''</strong>),<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>`- Value (excl. VAT): </strong>${<strong>this</strong>.value}<strong>`</strong>,<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>`- Value (VAT </strong>${<strong>this</strong>.VAT}<strong>%): </strong>${<strong>this</strong>.value * (1 + <strong>this</strong>.VAT / 100)}<strong>`<br /> &nbsp;&nbsp;&nbsp; </strong>];<br /> &nbsp;&nbsp;&nbsp; <strong>return </strong>output.join(<strong>'</strong><strong>\n</strong><strong>'</strong>);<br /> &nbsp; }<br /> }</p>
</td>
</tr>
</tbody>
</table>
<h3>Functionality</h3>
<p>The above code defines a <strong>class</strong> that contains information about a <strong>payment package</strong>. An <strong>instance</strong> of the class should support the following operations:</p>
<ul>
<li>Can be <strong>instantiated</strong> with two parameters &ndash; a string name and number value</li>
<li>Accessor name &ndash; used to get and set the value of name</li>
<li>Accessor value &ndash; used to get and set the value of value</li>
<li>Accessor VAT &ndash; used to get and set the value of VAT</li>
<li>Accessor active &ndash; used to get and set the value of active</li>
<li>Function toString() &ndash; return a string, containing an overview of the instance; if the package is <strong>not active</strong>, append the label "<strong>(inactive)</strong>" to the printed <strong>name</strong></li>
</ul>
<p>When creating an instance, or changing any of the property values, the parameters are validated. They must follow these rules:</p>
<ul>
<li>name &ndash; non-empty string</li>
<li>value &ndash; non-negative number</li>
<li>VAT &ndash; non-negative number</li>
<li>active &ndash; Boolean</li>
</ul>
<p>If any of the requirements aren&rsquo;t met, the operation must throw an error.</p>
<p>&nbsp;</p>
<p><strong><em>Scroll down for examples and details about submitting to Judge.</em></strong></p>
<p>&nbsp;</p>
<p><strong>&nbsp;</strong></p>
<h3>Examples</h3>
<p>This is an example how this code is <strong>intended to be used</strong>:</p>
<table width="1391">
<tbody>
<tr>
<td width="1391">
<p>Sample code usage</p>
</td>
</tr>
<tr>
<td width="1391">
<p><em>// Should throw an error<br /> </em><strong>try </strong>{<br /> &nbsp;&nbsp;&nbsp; <strong>const </strong><strong><em>hrPack </em></strong>= <strong>new </strong>PaymentPackage(<strong>'HR Services'</strong>);<br /> } <strong>catch</strong>(err) {<br /> &nbsp;&nbsp;&nbsp; <strong>console</strong>.log(<strong>'Error: ' </strong>+ err.<strong>message</strong>);<br /> }<br /> <strong>const </strong><strong><em>packages </em></strong>= [<br /> &nbsp;&nbsp;&nbsp; <strong>new </strong>PaymentPackage(<strong>'HR Services'</strong>, 1500),<br /> &nbsp;&nbsp;&nbsp; <strong>new </strong>PaymentPackage(<strong>'Consultation'</strong>, 800),<br /> &nbsp;&nbsp;&nbsp; <strong>new </strong>PaymentPackage(<strong>'Partnership Fee'</strong>, 7000),<br /> ];<br /> <strong>console</strong>.log(<strong><em>packages</em></strong>.join(<strong>'</strong><strong>\n</strong><strong>'</strong>));<br /> <br /> <strong>const </strong><strong><em>wrongPack </em></strong>= <strong>new </strong>PaymentPackage(<strong>'Transfer Fee'</strong>, 100);<br /> <em>// Should throw an error<br /> </em><strong>try </strong>{<br /> &nbsp;&nbsp;&nbsp; <strong><em>wrongPack</em></strong>.active = <strong>null</strong>;<br /> } <strong>catch</strong>(err) {<br /> &nbsp;&nbsp;&nbsp; <strong>console</strong>.log(<strong>'Error: ' </strong>+ err.<strong>message</strong>);<br /> }</p>
</td>
</tr>
<tr>
<td width="1391">
<p>Corresponding output</p>
</td>
</tr>
<tr>
<td width="1391">Error: Value must be a non-negative numberPackage: HR Services- Value (excl. VAT): 1500- Value (VAT 20%): 1800Package: Consultation- Value (excl. VAT): 800- Value (VAT 20%): 960Package: Partnership Fee- Value (excl. VAT): 7000- Value (VAT 20%): 8400Error: Active status must be a boolean</td>
</tr>
</tbody>
</table>
<h3>Your Task</h3>
<p>Using <strong>Mocha</strong> and <strong>Chai</strong> write <strong>JS unit tests</strong> to test the entire functionality of the PaymentPackage class. Make sure instances of it have all the required functionality and validation. You may use the following code as a template:</p>
<table width="1385">
<tbody>
<tr>
<td width="1385">describe(<strong>"<em>TODO</em> &hellip;"</strong>, <strong>function</strong>() {<br /> &nbsp;&nbsp;&nbsp; <strong><em>it</em></strong>(<strong>"<em>TODO &hellip;</em>"</strong>, <strong>function</strong>() {&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <em>// </em><strong><em>TODO: </em></strong>&hellip;&nbsp;&nbsp;&nbsp; });<br /> &nbsp;&nbsp;&nbsp; <em>// </em><strong><em>TODO: </em></strong>&hellip;});</td>
</tr>
</tbody>
</table>
<h3>Submission</h3>
<p>Submit your tests inside a describe() statement, as shown above.</p>


<h1>JS Advanced: Exam 18 March 2018</h1>
<p>Problems for exam preparation for the <a href="https://softuni.bg/courses/javascript-advanced">&ldquo;JavaScript Advanced&rdquo; course @ SoftUni</a>. Submit your solutions in the SoftUni judge system at <a href="https://judge.softuni.bg/Contests/974/">https://judge.softuni.bg/Contests/974/</a>.</p>
<h1>Problem 3. Payment Processor (Simple Class)</h1>
<p>Write a JavaScript class PaymentProcessor that keeps information about a <strong>collection</strong> of payments with their <strong>ID</strong>, <strong>name</strong>, <strong>type</strong> and <strong>value</strong>.</p>
<table width="1391">
<tbody>
<tr>
<td width="1391">
<p><strong>class </strong>PaymentProcessor {<br /> &nbsp;&nbsp;&nbsp; <em>// </em><strong><em>TODO: implement this class<br /> </em></strong>}</p>
</td>
</tr>
</tbody>
</table>
<p>The class constructor receives an <strong>optional object parameter</strong> that defines its behavior (see below for details). Implement the following features:</p>
<p>Function registerPayment(id, name, type, value) &ndash; validate input parameters and save the payment; throw and error if the validation fails (see below for details)</p>
<p>Function deletePayment(id) &ndash; removes the requested payment; throw an error if it&rsquo;s not found</p>
<p>Function get(id) &ndash; returns a string, containing information about the requested payment (see examples for formatting details); throw an error if it&rsquo;s not found</p>
<p>Function setOptions(options) &ndash; modify the processor&rsquo;s options</p>
<p>Function toString() &ndash; return a string, containing a summary about all recorded payments (see examples for formatting details)</p>
<p>The options parameter that the <strong>constructor</strong> takes is an <strong>object</strong> with the following format:</p>
<p>{</p>
<p>&nbsp; types: [String],</p>
<p>&nbsp; precision: Number</p>
<p>}</p>
<p>When processing <strong>new options</strong> (either through the <strong>constructor</strong> or the setOptions function), only replace the properties that are supplied &ndash; e.g. if only types are given, replace the existing types value (entire array), leaving precision unchanged. If not specified, use the following <strong>default values</strong>:</p>
<p>{</p>
<p>&nbsp; types: ["service", "product", "other"],</p>
<p>&nbsp; precision: 2</p>
<p>}</p>
<p>A <strong>valid</strong> payment will have an <strong>ID</strong> and <strong>name</strong> that are <strong>non-empty strings</strong>, a <strong>value</strong> that is a <strong>number</strong> and a <strong>type</strong> that is listed in options. If a payment with the <strong>same ID</strong> already <strong>exists</strong>, consider the new one <strong>invalid</strong>. For any discrepancy, <strong>throw an error</strong> and <strong>ignore</strong> the payment. When recording the payment, round its value to the number of decimal places, specified in options.precision.</p>
<p><strong><em>Scroll down for examples and constraints.</em></strong></p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<h3>Examples</h3>
<table width="1391">
<tbody>
<tr>
<td width="1391">
<p>Sample code usage</p>
</td>
</tr>
<tr>
<td width="1391"><em>// Initialize processor with default options<br /> </em><strong>const </strong>generalPayments = <strong>new </strong>PaymentProcessor();<br /> generalPayments.registerPayment(<strong>'0001'</strong>, <strong>'Microchips'</strong>, <strong>'product'</strong>, 15000);<br /> generalPayments.registerPayment(<strong>'01A3'</strong>, <strong>'Biopolymer'</strong>, <strong>'product'</strong>, 23000);<br /> <strong><em>console</em></strong>.log(generalPayments.toString());<br /> <br /> <em>// Should throw an error (invalid type)<br /> </em>generalPayments.registerPayment(<strong>'E028'</strong>, <strong>'Rare-earth elements'</strong>, <strong>'materials'</strong>, 8000);<br /> <br /> generalPayments.setOptions({<strong>types</strong>: [<strong>'product'</strong>, <strong>'material'</strong>]});<br /> generalPayments.registerPayment(<strong>'E028'</strong>, <strong>'Rare-earth elements'</strong>, <strong>'material'</strong>, 8000);<br /> <strong><em>console</em></strong>.log(generalPayments.get(<strong>'E028'</strong>));<br /> generalPayments.registerPayment(<strong>'CF15'</strong>, <strong>'Enzymes'</strong>, <strong>'material'</strong>, 55000);<br /> <br /> <em>// Should throw an error (ID not found)<br /> </em>generalPayments.deletePayment(<strong>'E027'</strong>);<br /> <em>// Should throw an error (ID not found)<br /> </em>generalPayments.get(<strong>'E027'</strong>);<br /> <br /> generalPayments.deletePayment(<strong>'E028'</strong>);<br /> <strong><em>console</em></strong>.log(generalPayments.toString());<br /> <br /> <em>// Initialize processor with custom types<br /> </em><strong>const </strong>servicePyaments = <strong>new </strong>PaymentProcessor({<strong>types</strong>: [<strong>'service'</strong>]});<br /> servicePyaments.registerPayment(<strong>'01'</strong>, <strong>'HR Consultation'</strong>, <strong>'service'</strong>, 3000);<br /> servicePyaments.registerPayment(<strong>'02'</strong>, <strong>'Discount'</strong>, <strong>'service'</strong>, -1500);<br /> <strong><em>console</em></strong>.log(servicePyaments.toString());<br /> <br /> <em>// Initialize processor with custom precision<br /> </em><strong>const </strong>transactionLog = <strong>new </strong>PaymentProcessor({<strong>precision</strong>: 5});<br /> transactionLog.registerPayment(<strong>'b5af2d02-327e-4cbf'</strong>, <strong>'Interest'</strong>, <strong>'other'</strong>, 0.00153);<br /> <strong><em>console</em></strong>.log(transactionLog.toString());</td>
</tr>
<tr>
<td width="1391">
<p>Corresponding output</p>
</td>
</tr>
<tr>
<td width="1391">Summary:- Payments: 2- Balance: 38000.00Details about payment ID: E028- Name: Rare-earth elements- Type: material- Value: 8000.00Summary:- Payments: 3- Balance: 93000.00Summary:- Payments: 2- Balance: 1500.00Summary:- Payments: 1- Balance: 0.00153</td>
</tr>
</tbody>
</table>
<h3>Constraints</h3>
<ul>
<li>Your class will be tested with both <strong>valid and invalid parameters</strong> and should validate the input to registerPayment, deletePayment, get and setOptions</li>
<li>Your class will be tested with <strong>only valid options</strong></li>
</ul>
<h3>Submission</h3>
<p>Submit <strong>only</strong> your class PaymentProcessor.</p>
<h3>Hint</h3>
<p>To create a string, that contains a line break, use the special character '\n'.</p>


<h1>JS Advanced: Exam 18 March 2018</h1>
<p>Problems for exam preparation for the <a href="https://softuni.bg/courses/javascript-advanced">&ldquo;JavaScript Advanced&rdquo; course @ SoftUni</a>. Submit your solutions in the SoftUni judge system at <a href="https://judge.softuni.bg/Contests/974/">https://judge.softuni.bg/Contests/974/</a>.</p>
<h1>Problem 4. Payment Manager (Object Interacting with DOM)</h1>
<p>Write a JS <strong>class</strong> with the name <strong>"PaymentManager"</strong> that generates and controls a <strong>payment manager </strong>table. It contains <strong>three columns</strong> for payments data <strong>(Name, Category, Price) </strong>and <strong>one column</strong> for <strong>Actions - [Add]</strong> and <strong>[Delete] </strong>buttons<strong>.&nbsp; </strong>The <strong>last row</strong> of the table consists of <strong>three</strong> <strong>input fields </strong>and a <strong>[Add] </strong>button. There can be <strong>multiple</strong> <strong>payment manager </strong><strong>tables</strong> &ndash; i.e. instances of the JS class. <em>See the examples and templates for more details.</em></p>
<p>The <strong>constructor</strong> of your class needs to take <strong>one</strong> argument &ndash; <strong>title</strong> (string). The <strong>title</strong> should be used in the table&rsquo;s title (&lt;caption&gt;). <em>See the table&rsquo;s HTML template for more details below</em>.</p>
<p>&nbsp;Additionally, the <strong>class</strong> <strong>should</strong> <strong>contain</strong> the following <strong>functionality</strong>:</p>
<ul>
<li>Function render(id) &ndash; takes <strong>one</strong> (string) argument, <strong>generates the table&rsquo;s HTML element </strong>and <strong>appends</strong> it to the <strong>element in the DOM</strong> <strong>with ID equal</strong> to the argument</li>
</ul>
<p>The <strong>table</strong> <strong>consists of</strong> a <strong>title</strong>, <strong>four columns</strong> (name, category, price and actions), <strong>three input fields</strong> and <strong>two</strong> <strong>types</strong> of <strong>buttons</strong> (add, delete). You <strong>should</strong> <strong>use</strong> the following <strong>HTML structure</strong> <strong>for</strong> generating the <strong>table</strong>:</p>
<table width="1391">
<tbody>
<tr>
<td width="1391">
<p>Template Table</p>
</td>
</tr>
<tr>
<td width="1391">
<p>&lt;table&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;caption&gt;{Title} Payment Manager&lt;/caption&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;thead&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;tr&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;th <em>class</em>="name"&gt;Name&lt;/th&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;th <em>class</em>="category"&gt;Category&lt;/th&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;th <em>class</em>="price"&gt;Price&lt;/th&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;th&gt;Actions&lt;/th&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/tr&gt;</p>
<p>&nbsp;&nbsp; &lt;/thead&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;tbody <em>class</em>="payments"&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;tr&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;td&gt;<em>&lt;!-- Payment's name --&gt;</em>&lt;/td&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;td&gt;<em>&lt;!-- Payment's category --&gt;</em>&lt;/td&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;td&gt;<em>&lt;!-- Payment's price --&gt;</em>&lt;/td&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;td&gt;&lt;button&gt;Delete&lt;/button&gt;&lt;/td&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/tr&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;tr&gt;...&lt;/tr&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;/tbody&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;tfoot <em>class</em>="input-data"&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;tr&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;td&gt;&lt;input <em>name</em>="name" <em>type</em>="text"&gt;&lt;/td&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;td&gt;&lt;input <em>name</em>="category" <em>type</em>="text"&gt;&lt;/td&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;td&gt;&lt;input <em>name</em>="price" <em>type</em>="number"&gt;&lt;/td&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;td&gt;&lt;button&gt;Add&lt;/button&gt;&lt;/td&gt;&lt;/tr&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;/tfoot&gt;</p>
<p>&lt;/table&gt;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<p><strong>Types </strong>of <strong>values</strong> in a <strong>payment&rsquo;s</strong> <strong>columns</strong>:</p>
<ul>
<li><strong>Name &ndash; string</strong></li>
<li><strong>Category &ndash; string</strong></li>
<li><strong>Price &ndash; number</strong></li>
</ul>
<p>Every <strong>input box </strong>corresponds to the <strong>payment&rsquo;s column </strong>it is<strong> placed on</strong>, where the data should be added.</p>
<p>Furthermore, when <strong>clicked</strong> the table&rsquo;s <strong>buttons</strong> should have the following <strong>functionality</strong>:</p>
<p><strong>[Add] button:</strong></p>
<ul>
<li><strong>Appends</strong> the <strong>text</strong> received from the <strong>input boxes </strong>and a <strong>[Delete] </strong>button as a <strong>new</strong> <strong>row at the end </strong>of the <strong>table&rsquo;s payments</strong></li>
<li><strong>Clears </strong>the <strong>input boxes </strong>after the <strong>payment&rsquo;s information</strong> is <strong>submitted</strong></li>
<li><strong>Do nothing </strong>if <strong>either</strong> of the <strong>text boxes </strong>is <strong>empty</strong></li>
</ul>
<p><strong>[Delete] button:</strong></p>
<ul>
<li>Should<strong> remove</strong> the table&rsquo;s <strong>row</strong>, where it is placed on</li>
</ul>
<p>Note that, <strong>every button&rsquo;s functionality</strong> should work <strong>only</strong> for the <strong>table</strong> <strong>where it is located on</strong>.</p>
<h3>Submission</h3>
<p>Submit only your <strong>PaymentManager</strong> class.</p>
<h3>Examples</h3>
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
<p>&lt;!DOCTYPE html&gt;</p>
<p>&lt;html <em>lang</em>="en"&gt;</p>
<p>&lt;head&gt;</p>
<p>&nbsp; &lt;meta <em>charset</em>="UTF-8"&gt;</p>
<p>&nbsp; &lt;title&gt;Payment Manager&lt;/title&gt;</p>
<p>&nbsp; &lt;style&gt;</p>
<p>&nbsp;&nbsp;&nbsp; body{padding:30px}div{margin-bottom:20px}table{border:1px solid #000;border-collapse:collapse;margin:auto}caption{font-size:20px;font-weight:700;color:#fff;background:#000;padding:5px}td,th{padding:5px 20px;text-align:center}tfoot td,th{background:#ccc}tr<em>:</em><em>nth-child</em>(odd){background:#eee}tr<em>:</em><em>nth-child</em>(even){background:#ddd}tfoot{border-top:1px solid #000}tfoot&gt;tr td{font-style:italic;font-weight:700}button{margin:auto;cursor:pointer}</p>
<p>&nbsp; &lt;/style&gt;</p>
<p>&nbsp; &lt;script <em>src</em>="https://code.jquery.com/jquery-3.3.1.min.js"&gt;&lt;/script&gt;</p>
<p>&lt;/head&gt;</p>
<p>&lt;body&gt;</p>
<p>&nbsp;</p>
<p>&nbsp; &lt;div <em>id</em>="amazon"&gt;&lt;/div&gt;</p>
<p>&nbsp;</p>
<p>&nbsp; &lt;div <em>id</em>="ebay"&gt;&lt;/div&gt;</p>
<p>&nbsp;</p>
<p>&nbsp; &lt;div <em>id</em>="walmart"&gt;&lt;/div&gt;</p>
<p>&nbsp;</p>
<p>&nbsp; &lt;script <em>src</em>="./solution.js"&gt;&lt;/script&gt;</p>
<p>&nbsp; &lt;script&gt;</p>
<p>&nbsp;&nbsp;&nbsp; $(function() {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; let paymentMangersData = [</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ['amazon', 'Amazon'],</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ['ebay', 'eBay'],</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ['walmart', 'Walmart'],</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <em>// Others</em></p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ]</p>
<p>&nbsp;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <em>for</em> (let [target, title] of paymentMangersData) {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; let paymentManager = new PaymentManager(title)</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; paymentManager.render(target)</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;&nbsp;&nbsp; })</p>
<p>&nbsp; &lt;/script&gt;</p>
<p>&lt;/body&gt;</p>
<p>&lt;/html&gt;</p>
</td>
</tr>
</tbody>
</table>
<p>The sample page contains three main table&rsquo;s element and a script. The script will create two different payment manager tables that should look like the examples, if your code is correct. There is a third commented out manager&rsquo;s data that you can use in the script. You need to put the files &ndash; index.html and solutions.js (where is your PaymentManager class) &ndash; in the same directory for them to work with the default code.</p>
<p>In the <strong>first example </strong>we will use only the first payment manager&rsquo;s data in the script and generate only one table.</p>
<p><strong>Initial table rendering</strong>:</p>
<p>Use the "Template Table" skeleton to build your table.</p>
<table width="100%">
<tbody>
<tr>
<td>
<p>We add the first payment and two more after that, becoming the total of three payments.</p>
</td>
</tr>
</tbody>
</table>
<p><strong>Adding</strong> the <strong>first payment</strong>:</p>
<p>Then we add two more payments &ndash; "JavaScript The Good Parts" and "Audeze LCD-3" and click to delete a payment:</p>
<p>After deleting the payment with column name&rsquo;s value &ndash; "Audeze LCD-3":</p>
<p>In the <strong>second example </strong>we will use two payment manager&rsquo;s data in the script to generate two tables.</p>
<p><strong>Initial table</strong><strong>s rendering</strong>:</p>
<p>Chain of <strong>commands</strong> to the tables:</p>
<ul>
<li><strong>Adding</strong> payments to Amazon Payment Manager</li>
<li>[ "Logitech MX Master", "Mouses", "99" ]</li>
<li>[ "Dell XPS 13", "Computers", "99" ]</li>
<li>[ "Oree Board", "Keyboards", "80" ]</li>
<li><strong>Adding</strong> payments to eBay Payment Manager</li>
<li>[ "V60 Cherry Dolch", "Keyboards", "105" ]</li>
<li>[ "Asus Zenbook 13", "Computers", "34" ]</li>
</ul>
<p>More commands:</p>
<ul>
<li><strong>Delete</strong> the <strong>payment</strong> with column name "Logitech MX Master" from <strong>Amazon Payment Manager</strong></li>
</ul>
<p>More commands:</p>
<ul>
<li><strong>Adding </strong>a<strong> payment </strong>to <strong>eBay Payment Manager</strong>:</li>
<li>[ "Oree Board", "Keyboards", "80" ]</li>
<li><strong>Delete </strong>the <strong>payment</strong> with column name "Oree Board" from <strong>Amazon Payment Manager</strong></li>
<li><strong>Adding </strong>a <strong>payment </strong>to <strong>Amazon Payment Manager</strong>:</li>
<li>[ "V60 Cherry Dolch", "Keyboards", "105" ]</li>
<li><strong>Delete</strong> the <strong>payment</strong> with column name "Asus Zenbook 13" from <strong>eBay Payment Manager</strong></li>
<li><strong>Delete</strong> the <strong>payment</strong> with column name "V60 Cherry Dolch" from <strong>eBay Payment Manager</strong></li>
</ul>