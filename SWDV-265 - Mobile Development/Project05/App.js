import React, {Component, useEffect, useState } from "react";
import { Alert, Modal, StyleSheet, Text, TextInput, Pressable, View, Image, ImageBackground, ScrollView }
from "react-native";
import { NetInfo, useNetInfo } from "@react-native-community/netinfo";
import Icon from "react-native-vector-icons/MaterialIcons";
import Swiper from "react-native-swiper";
import ErrorBoundary from "./components/ErrorBoundary/ErrorBoundary"
import { RFPercentage, RFValue } from "react-native-responsive-fontsize";
import Hourly from "./components/Accordian/Accordian"

const App = () => {
  const [modalVisible, setModalVisible] = useState(false);
  const [modalVisible2, setModalVisible2] = useState(false);
  const [update , setUpdate] = useState()
  const netInfo = useNetInfo();
  const [zip, setZip] = useState('83642');
  const api_get = 'https://api.weatherapi.com/v1/forecast.json?key=81a223350214425cafe02104222009&q='+JSON.stringify(zip)+'&days=1'
  const api_send = api_get.replace(/['"]+/g, '')

  const [isLoading, setLoading] = useState(true);
  const [data, setData] = useState([]);
  const [hourlyForecast, setHourlyForecast] = useState([]);
  const [day, isDay] = useState(false);

  useEffect(() => {
    fetchData();
  }, [update]);

  const fetchData = async () => {
    console.log('Fetching Data')
    setLoading(true);
    await fetch(api_send)
      .then(response => {
        if (response.status >= 200 && response.status <= 299) {
          return response.json();
        } else {
          throw Error(response.statusText);
        }
      })
      .then((data) => {
        setData(data);
        setLoading(false);
        if (data.current.is_day == 0) {
          isDay(false);
        } else {
          isDay(true);
        }
        setHourlyForecast(data['forecast']['forecastday'][0]['hour']);
        console.log('Got Data')
        console.log('is_day: ' + day);
      })
      .catch((error) => {
        console.log(error);
      })
    }

  onSubmit = () => {
    let zipcode = parseInt(zip)
    if (zip.length > 6 || zip.length < 5) {
      Alert.alert('Zip Code Error:', 'Zip code must be 5 characters long.')
      return;
    } if (!Number.isInteger(zipcode)) {
      Alert.alert('Zip Code Error:', 'Zip code must be a number.')
      return;
    } else {
      setModalVisible(!modalVisible);
      netInfo.isConnected ? (
        setUpdate(!update)
      ) : (setModalVisible2(true))
    }
  }

  var hourByHour = [];
  for(var key in hourlyForecast){
    hourByHour.push({
      id: key, 
      is_day: hourlyForecast[key]['is_day'], 
      condition: hourlyForecast[key]['condition']['text'],
      conditionIcon: hourlyForecast[key]['condition']['icon'],
      time: hourlyForecast[key]['time'],
      temp: hourlyForecast[key]['temp_f'],
      timeInt: parseInt((hourlyForecast[key]['time']).substring(11,(hourlyForecast[key]['time']).length - 3))
    })
  }

  return (
    <View style={styles.container}>
      <ErrorBoundary>
        <View style={styles.header}>
          <Icon name = {'landscape'} size={30} color={'white'}/>
          <Text style={styles.headertext}>
            Weather Data
          </Text>
          <View>
            {netInfo.isConnected ? (
                <Icon name = {'wifi'} size={30} color={'lightgreen'} />
              ) : (
                <Icon name = {'wifi-off'} size={30} color={'red'} />
              )
            }
          </View>
        </View>
        <Swiper loop={true} showButtons={true} removeClippedSubviews={false}>
          <View style={styles.container}>
            {day==false ? 
              <ImageBackground source={require('./media/Background/back17.jpg')} resizeMode = 'cover' style={styles.imagebackground}>
                <View style={styles.centeredView}>
                  {isLoading ? <Text style={styles.night}>Loading...</Text> :
                    ( 
                      <View>
                        <Text style={[styles.night, styles.location]}>
                          {data.location.name}, {data.location.region}
                        </Text>
                        <View style={styles.hrNight}/>
                        <Text style={[styles.night, styles.temp]}>
                          {data.current.temp_f.toFixed(1)}&deg;
                        </Text>
                        <View style={styles.hrNight}/>
                        <View style={styles.conditionrow}>
                          <Image style={styles.conditionIcon} source={{uri : 'http:' + data.current.condition.icon}}/>
                          <Text style={[styles.night, styles.condition]}>
                            {data.current.condition.text}
                          </Text>
                        </View>
                        <Text style={[styles.night, styles.highlow, styles.highlowrow]}>
                          <Text>
                            L: {data.forecast.forecastday[0].day.mintemp_f}&deg;
                          </Text>
                          &nbsp;&nbsp;
                          <Text>
                            H: {data.forecast.forecastday[0].day.maxtemp_f}&deg;
                          </Text>
                        </Text>
                      </View>
                    )
                  }
                  <View style={styles.space}>
                  </View>
                  <Modal
                    animationType="slide"
                    transparent={true}
                    visible={modalVisible2}
                  >
                    <View style={styles.centeredView}>
                      <View style={styles.modalView}>
                        <Text style={styles.modalText}>Network Not Connected</Text>
                        <Pressable
                        style={[styles.button, styles.buttonClose]}
                        onPress={() => {
                          setModalVisible2(!modalVisible2);
                        }}
                        >
                          <Text style={[styles.night, styles.buttonText]}>Dismiss</Text>
                        </Pressable>
                      </View>
                    </View>
                  </Modal>
                  <Modal
                    animationType="slide"
                    transparent={true}
                    visible={modalVisible}
                  >
                    <View style={styles.centeredView}>
                      <View style={styles.modalView}>
                        <Text style={styles.modalText}>Change Zip Code:</Text>

                        <TextInput
                          style={{height: 60, width: 100, marginTop: 25, marginBottom: 25, fontSize: 20, backgroundColor: 'lightgrey', borderRadius: 15, fontSize: RFPercentage(2.5)}}
                          placeholder="Zip Code"
                          onChangeText={newZip => setZip(newZip)}
                          defaultValue={zip} />
                        <Pressable
                          style={[styles.button, styles.buttonClose]}
                          onPress={() => {
                            this.onSubmit();
                          }}
                        >
                          <Text style={[styles.night, styles.buttonText]}>Confirm</Text>
                        </Pressable>
                      </View>
                    </View>
                  </Modal>
                  <Pressable
                    style={[styles.button, styles.buttonOpen]}
                    onPress={() => setModalVisible(true)}
                  >
                    <Text style={[styles.night, styles.buttonText]}>Change Location</Text>
                  </Pressable>
                </View>
              </ImageBackground>
              : 
              <ImageBackground source={require('./media/Background/back16.jpg')} resizeMode = 'cover' style={styles.imagebackground}>
                <View style={styles.centeredView}>
                  {isLoading ? <Text style={styles.day}>Loading...</Text> :
                    ( 
                      <View>
                        <Text style={[styles.day, styles.location]}>
                          {data.location.name}, {data.location.region}
                        </Text>
                        <View style={styles.hrDay}/>
                        <Text style={[styles.day, styles.temp]}>
                          {data.current.temp_f.toFixed(1)}&deg;
                        </Text>
                        <View style={styles.hrDay}/>
                        <View style={styles.conditionrow}>
                          <Image style={styles.conditionIcon} source={{uri : 'http:' + data.current.condition.icon}}/>
                          <Text style={[styles.day, styles.condition]}>
                            &nbsp;&nbsp;{data.current.condition.text}
                          </Text>
                        </View>
                        <Text style={[styles.day, styles.highlow, styles.highlowrow]}>
                          <Text>
                            L: {data.forecast.forecastday[0].day.mintemp_f}&deg;
                          </Text>
                          &nbsp;&nbsp;
                          <Text>
                            H: {data.forecast.forecastday[0].day.maxtemp_f}&deg;
                          </Text>
                        </Text>
                      </View>
                    )
                  }
                  <View style={styles.space}>
                  </View>
                  <Modal
                    animationType="slide"
                    transparent={true}
                    visible={modalVisible2}
                  >
                    <View style={styles.centeredView}>
                      <View style={styles.modalView}>
                        <Text style={styles.modalText}>Network Not Connected</Text>
                        <Pressable
                        style={[styles.button, styles.buttonClose]}
                        onPress={() => {
                          setModalVisible2(!modalVisible2);
                        }}
                        >
                          <Text style={[styles.night, styles.buttonText]}>Dismiss</Text>
                        </Pressable>
                      </View>
                    </View>
                  </Modal>

                  <Modal
                    animationType="slide"
                    transparent={true}
                    visible={modalVisible}
                  >
                    <View style={styles.centeredView}>
                      <View style={styles.modalView}>
                        <Text style={styles.modalText}>Change Zip Code:</Text>

                        <TextInput
                          style={{height: 60, width: 100, marginTop: 25, marginBottom: 25, fontSize: 20, backgroundColor: 'lightgrey', borderRadius: 15, fontSize: RFPercentage(2.5)}}
                          placeholder="Zip Code"
                          onChangeText={newZip => setZip(newZip)}
                          defaultValue={zip} />
                        <Pressable
                          style={[styles.button, styles.buttonClose]}
                          onPress={() => {
                            this.onSubmit();
                          }}
                        >
                          <Text style={[styles.night, styles.buttonText]}>Confirm</Text>
                        </Pressable>
                      </View>
                    </View>
                  </Modal>
                  <Pressable
                    style={[styles.button, styles.buttonOpen]}
                    onPress={() => setModalVisible(true)}
                  >
                    <Text style={[styles.night, styles.buttonText]}>Change Location</Text>
                  </Pressable>
                </View>
              </ImageBackground>
            }
          </View>
          <ScrollView>
            {day==(false) ? 
              <ImageBackground source={require('./media/Background/back17.jpg')} resizeMode = 'cover' style={styles.imagebackground}>
                <View style={styles.hourlyContainer}>
                  {hourByHour.map((item, index) => (
                    <Hourly style={styles.item}
                      key = {item.id} 
                      condition = {item.condition}
                      icon = {item.conditionIcon}
                      day = {item.is_day}
                      time = {item.time}
                      timeInt = {item.timeInt}
                      temp = {item.temp}
                    >
                    </Hourly>
                  ))
                  }
                </View>
              </ImageBackground>
              :
              <ImageBackground source={require('./media/Background/back16.jpg')} resizeMode = 'cover' style={styles.imagebackground}>
                <View style={styles.hourlyContainer}>
                  {hourByHour.map((item, index) => (
                    <Hourly style={styles.item}
                      key = {item.id} 
                      condition = {item.condition}
                      icon = {item.conditionIcon}
                      day = {item.is_day}
                      time = {item.time}
                      timeInt = {item.timeInt}
                      temp = {item.temp}
                    >
                    </Hourly>
                  ))
                  }
                </View>
              </ImageBackground>
            }
          </ScrollView>
        </Swiper>
      </ErrorBoundary>
    </View>
  );
};

export default App

const styles = StyleSheet.create({
  container: {
    flex: 1,
    justifyContent: 'center'
  },
  hourlyContainer: {
    flex: 1,
    marginLeft: 25,
    marginRight: 25,
    marginTop: 25,
    marginBottom: 25,
  },
  centeredView: {
    flex: 1,
    justifyContent: "center",
    alignItems: "center",
    marginTop: 22
  },
  modalView: {
    margin: 20,
    backgroundColor: "white",
    borderRadius: 20,
    padding: 35,
    alignItems: "center",
    shadowColor: "#000",
    shadowOffset: {
      width: 0,
      height: 2
    },
    shadowOpacity: 0.25,
    shadowRadius: 4,
    elevation: 5
  },
  header: {
    height: 50,
    backgroundColor:'#004F59',
    flexDirection: 'row',
    justifyContent:'space-between',
    height:56,
    paddingLeft:15,
    paddingRight:18,
    alignItems:'center',
  },
  headertext: {
    textAlign: 'center',
    fontSize: 20,
    color: 'white',
  },
  day: {
    color: 'black',
  },
  night: {
    color: 'white',
  },
  location: {
    opacity: .75,
    fontSize: RFPercentage(5),
    textAlign: 'center',
    marginBottom: 10,
  },
  temp: {
    opacity: .75,
    fontSize: RFPercentage(15),
    textAlign: 'center',
  },
  condition: {
    fontSize: RFPercentage(3),
    textAlign: 'center',
    opacity: .75,
  },
  conditionIcon: {
    height: RFPercentage(8),
    width: RFPercentage(8),
  },
  conditionrow: {
    height: 50,
    flexDirection: 'row',
    justifyContent: 'center',
    alignItems:'center',
    marginTop: 10,
    marginBottom: 10,
  },
  highlow: {
    opacity: .75,
    fontSize: RFPercentage(2.3),
    textAlign: 'center',
  },
  highlowrow: {
    height: 40,
    marginLeft: 'auto',
    marginRight: 'auto',
    opacity: .75,
  },
  button: {
    borderRadius: 20,
    padding: 10,
    elevation: 2,
    marginTop: 10,
  },
  buttonText: {
    fontSize: RFPercentage(2.5),
  },
  buttonOpen: {
    backgroundColor: '#004F59',
  },
  buttonClose: {
    backgroundColor: '#004F59',
  },
  space: {
    height: '10%',
  },
  modalText: {
    marginBottom: 15,
    textAlign: "center",
    fontSize: RFPercentage(2.5)
  },
  hrDay:{
    borderBottomColor: 'black',
    borderBottomWidth: StyleSheet.hairlineWidth,
  },
  hrNight:{
    borderBottomColor: 'lightgrey',
    borderBottomWidth: StyleSheet.hairlineWidth,
  },
  imagebackground: {
    height: '100%',
    width: '100%',
  },
  item: {
    flexDirection: 'row',
    justifyContent: 'space-between',
    alignItems: 'center',
    padding: 30,
    margin: 2,
    borderColor: '#2a4944',
    borderWidth: 1,
    backgroundColor: '#d2f7f1',
  },
});