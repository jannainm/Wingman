// import React from "react";
// import {StyleSheet, FlatList, Text, View} from "react-native";

import React, {Component} from "react";
import {View, Text, FlatList} from "react-native";
import {List, ListItem} from "react-native-elements";

export default class App extends React.Component {
  // constructor() {
  //   super();
  //   this.state = {
  //     data: {
  //       [
  //         {
  //           name: { first: "person", last: "one"},
  //           email: "person@one.com"
  //           picture: {
  //             thumbnail: "http://cdn.wegotthiscovered.com/wp-content/uploads/2017/02/MV5BMTkxOTEwOTQwOV5BMl5BanBnXkFtZTcwODk2MTUzNA@@._V1_SX1777_CR001777999_AL_.jpg"
  //           }
  //         }
  //         {},
  //       ]
  //     }
  //   };
  // }

  // render() {
  //   return (
  //     <View style={styles.container}>
  //       <List>
  //         <FlatList
  //           data={this.state.data}
  //           renderItem={({item}) => (
  //             <ListItem
  //               roundAvatar
  //               title={`${item.name.first} ${item.name.last}`}
  //               subtitle={item.email}
  //               avatar={{uri: item.picture.thumbnail}}
  //             />
  //           )}
  //         />
  //       </List>
  //     </View>
  //   );
  // }

  constructor(props) {
    super(props);

    this.state = {
      loading: false,
      data: [],
      page: 1,
      seed: 1,
      error: null,
      refreshing: false
    };
  }

  componentDidMount() {
    this.makeRemoteRequest();
  }

  makeRemoteRequest = () => {
    const {page, seed} = this.state;
    const url = `https://randomuser.me/api/?seed=${seed}&page=${page}&results=20`;
    this.setState({loading: true});
    fetch(url)
      .then(res => res.json())
      .then(res => {
        this.setState({
          data: page === 1 ? res.results : [...this.state.data, ...res.results],
          error: res.error || null,
          loading: false,
          refreshing: false
        });
      })
      .catch(error => {
        this.setState({error, loading: false});
      });
  };

  // <ListItem
  //   roundAvatar
  //   title={`${item.name.first} ${item.name.last}`}
  //   subtitle={item.email}
  //   avatar={{uri: item.picture.thumbnail}}
  // />

  render() {
    return (
      // <View style={color: "red"}/>
      <List>
        <FlatList
          data={this.state.data}
          keyExtractor={item => item.email}
          renderItem={({item}) => (
            <View style={{flex: 1}}>
              <View>
                <Text>{"HI"}</Text>
              </View>
              <View>
                <Text>{"SI"}</Text>
              </View>
            </View>
          )}
        />
      </List>
    );
  }
}

// const styles = StyleSheet.create({
//   container: {
//     flex: 1,
//     backgroundColor: "#fff",
//     alignItems: "center",
//     justifyContent: "center"
//   }
// });
