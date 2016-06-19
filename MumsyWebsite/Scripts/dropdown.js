$(function () {
	$('.dropdown').each(function () {
		var $this = $(this);
		var $listItem = $this.parent('li');
		var listItemBottomLeft = (function () {
			var topLeft = $listItem.offset();
			return {
				top: topLeft.top + $this.height(),
				left: topLeft.left + $this.width()
			};
		}());
		var dropdownTopRight = (function () {
			var width = $this.width();
			return {
				top: listItemBottomLeft.top,
				left: listItemBottomLeft.left - width
			};
		});
		var css = Object.assign({}, dropdownTopRight, {
			position: "absolute"
		});
		$this.css(css);

		var mouseout = function(){
			$this.hide();
			$this.off('mouseout', mouseout);
			$listItem.off('mouseout', mouseout);
		};

		$listItem.on('mouseover', function(){
			$this.show();
			$this.on('mouseout', mouseout);
			$listItem.on('mouseout', mouseout);
		})
	})
})
