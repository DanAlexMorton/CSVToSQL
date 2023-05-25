import React, { Component } from 'react';
import authService from './api-authorization/AuthorizeService'

export class FetchData extends Component {
  static displayName = FetchData.name;

  constructor(props) {
    super(props);
    this.state = { persons: [], loading: true };
  }

  componentDidMount() {
    this.populatePersonData();
  }

  static renderPersonsTable(persons) {
    return (
      <table className="table table-striped" aria-labelledby="tableLabel">
        <thead>
          <tr>
            <th>First Name</th>
            <th>Last Name</th>
            <th>Job Title</th>
            <th>Email</th>
            <th>Department</th>
            <th>Contract Type</th>
            <th>Company Name</th>
            <th>Business Number</th>
            <th>Street Address 1</th>
            <th>Street Address 2</th>
            <th>City</th>
            <th>Postcode</th>
            <th>Country</th>
          </tr>
        </thead>
        <tbody>
          {persons.map((person, index) =>
            <tr key={index}>
              <td>{person.first_name}</td>
              <td>{person.last_name}</td>
              <td>{person.job_title}</td>
              <td>{person.email_address}</td>
              <td>{person.department}</td>
              <td>{person.contract_type}</td>
              <td>{person.company_name}</td>
              <td>{person.business_phone}</td>
              <td>{person.street}</td>
              <td>{person.street2}</td>
              <td>{person.postcode}</td>
              <td>{person.country}</td>
            </tr>
          )}
        </tbody>
      </table>
    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : FetchData.renderPersonsTable(this.state.persons);

    return (
      <div>
        <h1 id="tableLabel">Weather forecast</h1>
        <input type="text" />
        <button onClick={() => {}}>Submit</button>
        <p>This component demonstrates fetching data from the server.</p>
        {contents}
      </div>
    );
  }

  async populatePersonData() {
    const token = await authService.getAccessToken();
    const response = await fetch('person', {
      headers: !token ? {} : { 'Authorization': `Bearer ${token}` }
    });
    const data = await response.json();
    this.setState({ persons: data, loading: false });
  }
}
