import React from "react";

function CalculateScore({ Name, School, Total, goal }) {
	const percent = ((Total / goal) * 100).toFixed(2);

	const container = {
		fontFamily: "'Segoe UI', Tahoma, Geneva, Verdana, sans-serif",
		textAlign: "center",
		paddingTop: 40,
	};

	const header = {
		color: "#b22222",
		fontSize: 36,
		margin: 0,
		marginBottom: 18,
	};

	const infoRow = {
		margin: 6,
		fontSize: 16,
	};

	const labelStyle = (color) => ({ marginRight: 6, color, fontWeight: 700 });
	const valueStyle = (color) => ({ color, fontWeight: 600 });

	return (
		<div style={container}>
			<h1 style={header}>Student Details:</h1>

			<div style={infoRow}>
				<span style={labelStyle("#2b6cb0")}>Name:</span>
				<span style={valueStyle("#1e90ff")}>{Name}</span>
			</div>

			<div style={infoRow}>
				<span style={labelStyle("#d6336c")}>School:</span>
				<span style={valueStyle("#8b2be2")}>{School}</span>
			</div>

			<div style={infoRow}>
				<span style={labelStyle("#2e8b57")}>Total:</span>
				<span style={valueStyle("#2e8b57")}>{Total} Marks</span>
			</div>

			<div style={{ ...infoRow, marginTop: 8 }}>
				<span style={labelStyle("#228b22")}>Score:</span>
				<span style={valueStyle("#228b22")}>{percent}%</span>
			</div>
		</div>
	);
}

export default CalculateScore;

