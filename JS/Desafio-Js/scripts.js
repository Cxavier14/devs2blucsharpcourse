document.querySelector('#aba-1').addEventListener('click', (e) => {
    document.querySelector('#aba1').style.display = 'block';
    document.querySelector('#aba2').style.display = 'none';
    document.querySelector('#aba3').style.display = 'none';
    document.querySelector('#aba4').style.display = 'none';
})
document.querySelector('#aba-2').addEventListener('click', (e) => {
    document.querySelector('#aba1').style.display = 'none';
    document.querySelector('#aba2').style.display = 'block';
    document.querySelector('#aba3').style.display = 'none';
    document.querySelector('#aba4').style.display = 'none';
})
document.querySelector('#aba-3').addEventListener('click', (e) => {
    document.querySelector('#aba1').style.display = 'none';
    document.querySelector('#aba2').style.display = 'none';
    document.querySelector('#aba3').style.display = 'block';
    document.querySelector('#aba4').style.display = 'none';
})
document.querySelector('#aba-4').addEventListener('click', (e) => {
    document.querySelector('#aba1').style.display = 'none';
    document.querySelector('#aba2').style.display = 'none';
    document.querySelector('#aba3').style.display = 'none';
    document.querySelector('#aba4').style.display = 'block';
})
