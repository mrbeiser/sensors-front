window.drawCombinedChart = function (labels1, values1, labels2, values2) {
    debugger;
    const ctx = document.getElementById("myChart");

    const parse = arr => arr.map(v => parseFloat(v.toString().replace(",", ".")));

    if (window.temperatureChartInstance) {
        window.temperatureChartInstance.destroy();
    }

    window.temperatureChartInstance = new Chart(ctx, {
        type: 'line',
        data: {
            labels: labels1.length >= labels2.length ? labels1 : labels2,
            datasets: [
                {
                    label: 'Sensor 1',
                    data: parse(values1),
                    borderColor: 'rgba(0, 123, 255, 1)',
                    backgroundColor: 'rgba(0, 123, 255, 0.2)',
                    fill: false,
                    tension: 0.3
                },
                {
                    label: 'Sensor 2',
                    data: parse(values2),
                    borderColor: 'rgba(255, 99, 132, 1)',
                    backgroundColor: 'rgba(255, 99, 132, 0.2)',
                    fill: false,
                    tension: 0.3
                }
            ]
        },
        options: {
            responsive: true,
            interaction: {
                mode: 'index',
                intersect: false,
            },
            stacked: false,
            plugins: {
                title: {
                    display: true,
                    text: 'Temperature comparison – Sensor 1 vs Sensor 2'
                }
            },
            scales: {
                y: {
                    beginAtZero: false
                }
            }
        }
    });
};
