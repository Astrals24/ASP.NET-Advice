
onload = function() {
	var e, i = 0;
	while (e = document.getElementById('gallery').getElementsByTagName('DIV')[i++]) {
		if (e.className == 'on' || e.className == 'off') {
			e.onclick = function() {
				var getEls = document.getElementsByTagName('DIV');
				for ( var z = 0; z < getEls.length; z++) {
					getEls[z].className = getEls[z].className.replace('show',
							'hide');
					getEls[z].className = getEls[z].className.replace('on',
							'off');
				}
				this.className = 'on';
				var max = this.getAttribute('title');
				document.getElementById(max).className = "show";
			}
		}
	}
}