function create(sentences) {
    sentences.forEach(s=>{
        let div=document.createElement('div');
        let content=document.getElementById('content');
        let para=document.createElement('p');
        para.textContent=s;
        para.style.display='none';
        div.appendChild(para);
        div.addEventListener('click',(event)=>{
            event.target.children[0].style.display='block';
        });
        content.appendChild(div);
    })
}