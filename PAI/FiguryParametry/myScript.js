function ViewFigure(){
    var figureType = document.getElementById("figureSelect").value;
    var width = document.getElementById("widthFigure").value;
    var height = document.getElementById("heightFigure").value;
    var fill = document.getElementById("colorFigure").value;
    var svg = document.getElementById("viewBox");

    if (figureType == "poligon"){
        CreatePolygon(svg, width, height, fill);
    }
    else if (figureType == "circle"){
        CreateCircle(svg, width, fill);
    }
    else if (figureType == "rectangle"){
        CreateRectangle(svg, width, height, fill);
    }
    else{
        svg.innerHTML = '';
    }
}

function CreatePolygon(svg, width, height, fill){
    var points = `${width / 2},0 ${width},${height} 0,${height}`;
    var shape = `<polygon points="${points}" fill="${fill}" />`;
    svg.innerHTML = shape;
}

function CreateCircle(svg, width, fill){
    var radius = width / 2;
    var shape = `<circle cx="${radius}" cy="${radius}" r="${radius}" fill="${fill}" />`;
    svg.innerHTML = shape;
}

function CreateRectangle(svg, width, height, fill) {
    var shape = `<rect width="${width}" height="${height}" fill="${fill}" />`;
    svg.innerHTML = shape;
}
