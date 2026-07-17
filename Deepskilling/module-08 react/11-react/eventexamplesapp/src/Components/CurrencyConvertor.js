import React, { Component } from "react";

class CurrencyConvertor extends Component {
  constructor(props) {
    super(props);

    this.state = {
      amount: "",
      currency: "",
    };
  }

  handleChange = (e) => {
    this.setState({
      amount: e.target.value,
    });
  };

  handleSubmit = () => {
    const euro = (this.state.amount / 90).toFixed(2);

    this.setState({
      currency: euro,
    });
  };

  render() {
    return (
      <div>
        <h1 style={{ color: "green" }}>
          Currency Convertor!!!
        </h1>

        <table>
          <tbody>
            <tr>
              <td>Amount:</td>
              <td>
                <input
                  type="number"
                  value={this.state.amount}
                  onChange={this.handleChange}
                />
              </td>
            </tr>

            <tr>
              <td>Currency:</td>
              <td>
                <input
                  value={this.state.currency}
                  readOnly
                />
              </td>
            </tr>

            <tr>
              <td></td>
              <td>
                <button onClick={this.handleSubmit}>
                  Submit
                </button>
              </td>
            </tr>
          </tbody>
        </table>
      </div>
    );
  }
}

export default CurrencyConvertor;