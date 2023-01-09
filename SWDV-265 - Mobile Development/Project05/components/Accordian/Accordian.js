import React, {Component} from 'react';
import { View, Dimensions, Image, TouchableOpacity, Text, FlatList, StyleSheet, LayoutAnimation, Platform, UIManager} from "react-native";
import { Colors} from 'react-native/Libraries/NewAppScreen';

export default class Accordian extends Component{
  constructor(props) {
    super(props);
    this.state = { 
    data: props.condition,
    expanded : false,
    }
    if (Platform.OS === 'android') {
      UIManager.setLayoutAnimationEnabledExperimental(true);
    }
  }
  render() {
    return (
      <View style={styles.container}>
        {(this.props.day) == 0 ?
          <TouchableOpacity style={[styles.row, styles.nightBack]} onPress={()=>this.toggleExpand()}>
            <Image style={[styles.rowImage, styles.nightIcon]} source={{uri: 'http:' + this.props.icon}}/>
            <Text style={[styles.title, styles.nightText]}>
              { (this.props.timeInt) == 0 ? '12:00 AM'
              : (this.props.timeInt) < 12 ? (this.props.timeInt) + ':00 AM' 
              : (this.props.timeInt) == 12 ? '12:00 PM'
              : (this.props.timeInt) - 12 + ':00 PM'}
            </Text>
            <Text style={[styles.title, styles.nightText]}>
              {(this.props.temp).toFixed(1)}&deg;
            </Text>
          </TouchableOpacity>
          :
          <TouchableOpacity style={[styles.row, styles.dayBack]} onPress={()=>this.toggleExpand()}>
            <Image style={[styles.rowImage, styles.dayIcon]} source={{uri: 'http:' + this.props.icon}}/>
            <Text style={[styles.title, styles.dayText]}>
              { (this.props.timeInt) == 0 ? '12:00 AM'
              : (this.props.timeInt) < 12 ? (this.props.timeInt) + ':00 AM' 
              : (this.props.timeInt) == 12 ? '12:00 PM'
              : (this.props.timeInt) - 12 + ':00 PM'}
            </Text>
            <Text style={[styles.title, styles.dayText]}>
              {(this.props.temp).toFixed(1)}&deg;
            </Text>
          </TouchableOpacity>
        }
        <View style={styles.parentHr}/>
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
    dayText: {
      color: 'black',
    },
    dayBack: {
      backgroundColor: 'rgba(211,211,211, 0.7)'
    },
    dayIcon: {
      backgroundColor: 'rgba(102, 194, 255, 1)'
    },
    nightText: {
      color: 'white',
    },
    nightBack: {
      backgroundColor: 'rgba(0,0,0,0.6)'
    },
    nightIcon: {
      backgroundColor: 'rgba(0,0,0,0.9)'
    },
    row:{
        flexDirection: 'row',
        justifyContent:'space-between',
        height:56,
        paddingLeft:15,
        paddingRight:18,
        alignItems:'center',
        borderRadius: 5,
        borderColor: 'rgba(0,0,0,0.6)',
        borderWidth: 1,
    },
    rowImage: {
      flex: 1,
      minWidth: 40,
      maxWidth: 40,
      height: 40,
      resizeMode: 'contain',
      borderRadius: 5,
      borderWidth: 2,

    },
    parentHr:{
        height:3,
        color: Colors.WHITE,
        width:'100%'
    },
});