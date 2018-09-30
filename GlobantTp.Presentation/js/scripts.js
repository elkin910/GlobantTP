const President = ( props ) =>(
  <tr><td>{props.name}</td><td> {props.birthday}</td><td> {props.birthplace}</td><td> {props.deathday}</td><td> {props.deathplace}</td></tr>
)

class PresidentList extends React.Component{
  constructor(props){
    super(props)
    this.state = {
      presidents:[]
    }
  }
    
  componentWillMount(){
    var query ='';
    this.callService (query);
    
  }
  
  orderAsc = () => {
    var query ='?$orderby=Name%20asc'
    this.callService (query)
    
  };
  
   orderDesc = () =>{
    var query ='?$orderby=Name%20desc'
    this.callService (query)
    
  };
    
  callService = (query) => {
    fetch('https://globanttprestservice.azurewebsites.net/api/President'+query)
      
      .then(response => response.json())
      .catch(error => console.error('Error en Peticion:', error.message))
      .then(presidents =>{
        this.setState({presidents:this.state.presidents = []})
        presidents.forEach(president => {
          let data = {
            id:president.Id,
            name:president.Name,
            birthday:president.Birthday,
            birthplace:president.Birthplace,
            deathday:president.DeathDay,
            deathplace:president.DeathPlace
            
          }  
          console.log( data )
          
          this.setState({ presidents:this.state.presidents.concat([data]) })
        })
    })
  };

  render(){
    console.log( this.state.presidents.length )
    if( this.state.presidents.length > 0 ){
      return(
        <div>
          <button onClick={this.orderAsc} class='btn btn-warning pushme'>Order ASC</button>
          <span>       </span>
          <button onClick={this.orderDesc} class='btn btn-warning pushme'>Order DESC</button>
          <table>
             <tr>
                <th>Name</th>
                <th>Birth Day</th>
                <th>Birth Place</th>
                <th>Deaht Day</th>
                <th>Deaht Place</th>
              </tr>
          { this.state.presidents.map(president => <President key={president.id} name=           {president.name} birthday={president.birthday} birthplace={president.birthplace} deathday={president.deathday} deathplace={president.deathplace}/>) }
          </table>
        </div>
      )
  
    }
    return(
      <p>Loading Prersidents...</p>
    )
  }
}
ReactDOM.render(
  <PresidentList/>,
  document.getElementById('root'),
  null
)