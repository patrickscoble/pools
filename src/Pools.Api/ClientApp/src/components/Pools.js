import moment from 'moment';
import React, { useState } from 'react';
import '../custom.css';
import { getAllPoolsAsync, getTotalCostAsync } from '../services/PoolService';

export const Pools = () => {

  const [pools, setPools] = useState([]);
  const [totalCost, setTotalCost] = useState();

  const getAllPools = () => {
    getAllPoolsAsync()
      .then(data => {
        setPools(data);
      });
  }

  const getTotalCost = () => {
    getTotalCostAsync()
      .then(data => {
        setTotalCost(data);
      });
  }

  const poolTable = (pools) => {
    return (
      <table className='table table-striped' aria-labelledby="tabelLabel">
        <thead>
          <tr>
            <th>Reference Number</th>
            <th>Suburb</th>
            <th>Installation Date</th>
            <th>Volume (m3)</th>
            <th>Materials Cost ($)</th>
            <th>Labour Cost ($)</th>
            <th>Total Cost ($)</th>
          </tr>
        </thead>
        <tbody>
          {pools.map((pool, index) =>
            <tr key={index}>
              <td>{pool.referenceNumber}</td>
              <td>{pool.suburb}</td>
              <td>{moment(pool.installationDate).format('DD/MM/YYYY')}</td>
              <td>{pool.volume}</td>
              <td>{pool.materialCost ? pool.materialCost.toLocaleString() : ''}</td>
              <td>{pool.labourCost ? pool.labourCost.toLocaleString() : ''}</td>
              <td>{pool.totalCost ? pool.totalCost.toLocaleString() : ''}</td>
            </tr>
          )}
        </tbody>
      </table>
    );
  }

  const totalCostDiv = (totalCost) => {
    return (
      <div>
        <p>The <b>actual</b> total cost of the pools is $826,551.24.</p>
        <p>The <b>calculated</b> total cost of the pools is ${totalCost.toLocaleString()}.</p>
      </div>
    );
  }

  return (
    <div className="container">
      <h1>Background</h1>
      <p>This is a coding challenge for C#/.NET developers that has been built as a React/.NET Core web application.</p>
      <p>The application displays a collection of pools with different sizes and shapes.</p>
      <p>There are three types of pools: Circle, Rectangle and Square.</p>
      <p>The purpose of this challenge is to enhance the application and demonstrate your understanding of object-oriented development concepts.</p>
      <p>
        Please note the following:
        <ul>
          <li>To simulate a real-world development experience, Internet use is allowed and encouraged.</li>
          <li>No React changes are required.</li>
        </ul>
      </p>
      <h1>Instructions</h1>
      <ol>
        <li><del>Get the app up and running.</del> {`\u{2714}`}</li>
        <li>Determine why the 'Get All Pools' button is not working and fix the issue.</li>
        <li>Modify the Pool class to be an abstract class and the RectanglePool class to derive from the SquarePool class.</li>
        <li>The same HEIGHT constant has been added to all the Pool class models. Reduce code duplication by implementing it in a single location.</li>
        <li>Update the 'GetAll' endpoint to return all results ordered alphabetically by Suburb then by InstallationDate.</li>
        <li>Implement the functionality to calculate and display the Volume property for each pool.</li>
        <li>Implement the functionality to calculate and display the MaterialsCost property to two decimal places for each pool. (Note: The materials cost is calculated as $1,000 per cubic metre.)</li>
        <li>Implement the functionality to calculate and display the LabourCost property to two decimal places for each pool. (Note: The labour hours are calculated as 10 hours per cubic metre and are distributed evenly between each assigned worker.)</li>
        <li>Implement the functionality to calculate and display the TotalCost property to two decimal places for each pool.</li>
        <li>Implement the functionality for the 'Get Total Cost' button by adding a new endpoint. (Note: The endpoint should be called 'GetTotalCost'.)</li>
      </ol>
      <button type="button" onClick={() => getAllPools()} className="btn btn-primary">Get All Pools</button>
      <button type="button" onClick={() => getTotalCost()} className="btn btn-primary">Get Total Cost</button>
      {totalCost ? totalCostDiv(totalCost) : <p></p>}
      {pools.length ? poolTable(pools) : <p></p>}
    </div>
  )
}
