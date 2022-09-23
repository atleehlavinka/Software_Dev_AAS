import React, {Component} from 'react';
import { View, Dimensions, Image, TouchableOpacity, Text, FlatList, StyleSheet, LayoutAnimation, Platform, UIManager} from "react-native";
import { Colors} from 'react-native/Libraries/NewAppScreen';
import Icon from "react-native-vector-icons/MaterialIcons";

export default class Accordian extends Component{
  constructor(props) {
    super(props);
    this.state = { 
    data: props.description,
    expanded : false,
    }
    if (Platform.OS === 'android') {
      UIManager.setLayoutAnimationEnabledExperimental(true);
    }
  }
  render() {
    return (
      <View style={styles.container}>
        <TouchableOpacity style={styles.row} onPress={()=>this.toggleExpand()}>
          <Image style={styles.rowImage} source={this.props.icon} />
          <Text style={[styles.title]}>
            {this.props.name}
          </Text>
          <Icon name={this.state.expanded ? 'keyboard-arrow-up' : 'keyboard-arrow-down'} size={30} color={Colors.DARKGRAY} />
        </TouchableOpacity>
        <View style={styles.parentHr}/>
        {
        this.state.expanded &&
          <View style={{}}>
            <FlatList
              data={this.state.data[0]}
              numColumns={1}
              horizontal={true}
              scrollEnabled={false}
              renderItem={({item, index}) => 
              <View>
                <TouchableOpacity style={[item.value ? styles.btnActive : styles.btnInActive]} onPress={()=>this.onClick(index)}>
                  <View style={styles.childRow}>
                    <Image style={styles.childRowImage} source={this.props.image} />
                    <Text style={[styles.itemInActive]}>
                      {this.props.description}
                    </Text >
                  </View>
                </TouchableOpacity>
                <View style={styles.childHr}/>
                </View>
            }/>
          </View>
        }
      </View>
    )
  }
  onClick=(index)=>{
    const temp = this.state.data.slice()
    temp[index].value = !temp[index].value
    this.setState({data: temp})
  }
  toggleExpand=()=>{
    LayoutAnimation.configureNext(LayoutAnimation.Presets.easeInEaseOut);
    this.setState({expanded : !this.state.expanded})
  }
}

const styles = StyleSheet.create({
    container:{
        flex: 1
    },
    button:{
    },
    title:{
        fontSize: 14,
        fontWeight:'bold',
        color: Colors.DARKGRAY,
        textAlign: 'center'
    },
    itemActive:{
        fontSize: 12,
        color: Colors.GREEN,
    },
    itemInActive:{
        fontSize: 10,
        color: Colors.DARKGRAY,
        paddingLeft: 20,

    },
    btnActive:{
        borderColor: Colors.GREEN,
    },
    btnInActive:{
        borderColor: Colors.DARKGRAY,
    },
    row:{
        flexDirection: 'row',
        justifyContent:'space-between',
        height:56,
        paddingLeft:15,
        paddingRight:18,
        alignItems:'center',
        //backgroundColor: Colors.CGRAY,
        backgroundColor: '#f2f2f2'
    },
    childRow:{
      flexDirection: 'row',
      // width:'100%',
       minHeight:104,
       alignItems:'center',
       paddingLeft: 20,
       paddingTop: 15,
       paddingBottom: 15,
       paddingRight: 100,
       fontSize: 15,
       width: 370
    },
    rowImage: {
      flex: 1,
      minWidth: 40,
      maxWidth: 40,
      height: 40,
      resizeMode: 'contain',
      borderRadius: 5,
      borderColor: 'darkgrey',
      borderWidth: 2,
    },
    childRowImage: {
      flex: 1,
      minWidth: 100,
      maxWidth: 100,
      height: 100,
      resizeMode: 'contain',
      borderRadius: 50,

    },
    parentHr:{
        height:3,
        color: Colors.WHITE,
        width:'100%'
    },
    subHr:{
      height:3,
      color: Colors.BLACK,
      width:'100%'
  },
    childHr:{
        height:1,
        backgroundColor: Colors.LIGHTGRAY,
        width:'100%',
    },
    colorActive:{
        borderColor: Colors.GREEN
    },
    colorInActive:{
        borderColor: Colors.DARKGRAY
    }
});