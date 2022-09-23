import React, { Component } from 'react';
import { Text, Image, View, StyleSheet, ScrollView, ImageBackground } from 'react-native';
import Swiper from 'react-native-swiper'

import Accordian from './components/Accordian/Accordian'
import ErrorBoundary from './components/ErrorBoundary/ErrorBoundary';

const IMAGES = {
  cat1: require('./media/Animals/cat-1.jpg'),
  cat2: require('./media/Animals/cat-2.jpg'),
  cat3: require('./media/Animals/cat-3.jpg'),
  cat4: require('./media/Animals/cat-4.jpg'),
  cat5: require('./media/Animals/cat-5.jpg'),
  cat6: require('./media/Animals/cat-6.jpg'),
  cat7: require('./media/Animals/cat-7.jpg'),
  dog1: require('./media/Animals/dog-1.png'),
  dog2: require('./media/Animals/dog-2.jpg'),
  dog3: require('./media/Animals/dog-3.jpg'),
  dog4: require('./media/Animals/dog-4.jpg'),
  dog5: require('./media/Animals/dog-5.jpg'),
  dog6: require('./media/Animals/dog-6.jpg'),
  dog7: require('./media/Animals/dog-7.jpg'),
  bunny1: require('./media/Animals/bunny-1.jpg'),
  bunny2: require('./media/Animals/bunny-2.jpg'),
  ferret1: require('./media/Animals/ferret-1.jpg'),
  ferret2: require('./media/Animals/ferret-2.jpg'),
  gpig1: require('./media/Animals/gpig-1.jpg'),
  gpig2: require('./media/Animals/gpig-2.jpg'),
}

const ICONS = {
  icon1: require('./media/Icons/cat-icon2.jpg'),
  icon2: require('./media/Icons/dog-icon2.png'),
  icon3: require('./media/Icons/bunny-icon2.png'),
  icon4: require('./media/Icons/ferret-icon2.jpg'),
  icon5: require('./media/Icons/guinea-pig-icon2.png'),
}

const background = require('./media/Background/back14.jpg');

class Header extends Component {
  constructor(props) {
    super(props);
    this.state = {hasError: false};
  }
  changeState = () => this.setState({hasError: true})
  render() {
      if (this.state.hasError == true) {
        throw new Error("Header OnPress Error Testing")
      }
    return (
      <View style={styles.header}>
        <Text style={styles.headertext}
        onPress={this.changeState}>
          Animal Adoption
        </Text>
      </View>
    )
  }
};

class Pages extends Component {
  state = {
    names: [
       {image: IMAGES.dog5,    icon: ICONS.icon2, 'name': 'Rosey'   , 'id': 1, 'age': '7m', 'description': 'Temporibus autem quibusdam et aut officiis debitis aut rerum necessitatibus saepe eveniet ut et voluptates repudiandae sint et molestiae non recusandae. Itaque earum rerum hic tenetur a sapiente delectus, ut aut reiciendis voluptatibus maiores alias consequatur aut perferendis doloribus asperiores'},
       {image: IMAGES.gpig2,   icon: ICONS.icon5, 'name': 'Bear'    , 'id': 2, 'age': '5m', 'description': 'Temporibus autem quibusdam et aut officiis debitis aut rerum necessitatibus saepe eveniet ut et voluptates repudiandae sint et molestiae non recusandae. Itaque earum rerum hic tenetur a sapiente delectus, ut aut reiciendis voluptatibus maiores alias consequatur aut perferendis doloribus asperiores'},
       {image: IMAGES.cat1,    icon: ICONS.icon1, 'name': 'Tabby'   , 'id': 4,  'age': '3y', 'description': 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.'},
       {image: IMAGES.cat2,    icon: ICONS.icon1, 'name': 'Sweety'  , 'id': 5,  'age': '4y', 'description': 'Itaque earum rerum hic tenetur'},
       {image: IMAGES.ferret1, icon: ICONS.icon4, 'name': 'Badger'  , 'id': 3, 'age': '8m', 'description': 'Temporibus autem quibusdam et aut officiis debitis aut rerum necessitatibus saepe eveniet ut et voluptates repudiandae sint et molestiae non recusandae. Itaque earum rerum hic tenetur a sapiente delectus, ut aut reiciendis voluptatibus maiores alias consequatur aut perferendis doloribus asperiores'},
       {image: IMAGES.dog4,    icon: ICONS.icon2, 'name': 'Mishu'   , 'id': 6, 'age': '6m', 'description': 'Temporibus autem quibusdam et aut officiis debitis aut rerum necessitatibus saepe eveniet ut et voluptates repudiandae sint et molestiae non recusandae. Itaque earum rerum hic tenetur a sapiente delectus, ut aut reiciendis voluptatibus maiores alias consequatur aut perferendis doloribus asperiores'},
       {image: IMAGES.cat3,    icon: ICONS.icon1, 'name': 'Missy'   , 'id': 7,  'age': '3y', 'description': 'Itaque earum rerum hic tenetur'},
       {image: IMAGES.bunny1,  icon: ICONS.icon3, 'name': 'Archie'  , 'id': 17, 'age': '3m', 'description': 'Temporibus autem quibusdam et aut officiis debitis aut rerum necessitatibus saepe eveniet ut et voluptates repudiandae sint et molestiae non recusandae. Itaque earum rerum hic tenetur a sapiente delectus, ut aut reiciendis voluptatibus maiores alias consequatur aut perferendis doloribus asperiores'},
       {image: IMAGES.dog1,    icon: ICONS.icon2, 'name': 'Rocket'  , 'id': 8,  'age': '6m', 'description': 'Et harum quidem rerum facilis est et expedita distinctio. Nam libero tempore, cum soluta nobis est eligendi optio cumque nihil impedit quo minus id quod maxime placeat facere possimus, omnis voluptas assumenda est, omnis dolor repellendus. Temporibus autem quibusdam et aut officiis debitis aut rerum necessitatibus'},
       {image: IMAGES.cat6,    icon: ICONS.icon1, 'name': 'Rex'     , 'id': 9,  'age': '2y', 'description': 'Itaque earum rerum hic tenetur'},
       {image: IMAGES.cat7,    icon: ICONS.icon1, 'name': 'Charlie' , 'id': 10,  'age': '3y', 'description': 'Itaque earum rerum hic tenetur'},
       {image: IMAGES.ferret2, icon: ICONS.icon4, 'name': 'Alfred'  , 'id': 11, 'age': '2y', 'description': 'Temporibus autem quibusdam et aut officiis debitis aut rerum necessitatibus saepe eveniet ut et voluptates repudiandae sint et molestiae non recusandae. Itaque earum rerum hic tenetur a sapiente delectus, ut aut reiciendis voluptatibus maiores alias consequatur aut perferendis doloribus asperiores'},
       {image: IMAGES.gpig1,   icon: ICONS.icon5, 'name': 'Bubbles' , 'id': 12, 'age': '2m', 'description': 'Temporibus autem quibusdam et aut officiis debitis aut rerum necessitatibus saepe eveniet ut et voluptates repudiandae sint et molestiae non recusandae. Itaque earum rerum hic tenetur a sapiente delectus, ut aut reiciendis voluptatibus maiores alias consequatur aut perferendis doloribus asperiores'},
       {image: IMAGES.dog6,    icon: ICONS.icon2, 'name': 'Duke'    , 'id': 13, 'age': '3y', 'description': 'Temporibus autem quibusdam et aut officiis debitis aut rerum necessitatibus saepe eveniet ut et voluptates repudiandae sint et molestiae non recusandae. Itaque earum rerum hic tenetur a sapiente delectus, ut aut reiciendis voluptatibus maiores alias consequatur aut perferendis doloribus asperiores'},
       {image: IMAGES.dog7,    icon: ICONS.icon2, 'name': 'Harley'  , 'id': 14, 'age': '4m', 'description': 'Temporibus autem quibusdam et aut officiis debitis aut rerum necessitatibus saepe eveniet ut et voluptates repudiandae sint et molestiae non recusandae. Itaque earum rerum hic tenetur a sapiente delectus, ut aut reiciendis voluptatibus maiores alias consequatur aut perferendis doloribus asperiores'},
       {image: IMAGES.cat4,    icon: ICONS.icon1, 'name': 'Max'     , 'id': 15,  'age': '1y', 'description': 'Itaque earum rerum hic tenetur'},
       {image: IMAGES.cat5,    icon: ICONS.icon1, 'name': 'Stache'  , 'id': 16,  'age': '2y', 'description': 'Itaque earum rerum hic tenetur'},
       {image: IMAGES.bunny2,  icon: ICONS.icon3, 'name': 'Ellie'   , 'id': 18, 'age': '9m', 'description': 'Temporibus autem quibusdam et aut officiis debitis aut rerum necessitatibus saepe eveniet ut et voluptates repudiandae sint et molestiae non recusandae. Itaque earum rerum hic tenetur a sapiente delectus, ut aut reiciendis voluptatibus maiores alias consequatur aut perferendis doloribus asperiores'},
       {image: IMAGES.dog2,    icon: ICONS.icon2, 'name': 'Gunner'  , 'id': 20,  'age': '3y', 'description': 'Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit'},
       {image: IMAGES.dog3,    icon: ICONS.icon2, 'name': 'Chiba'   , 'id': 19, 'age': '2y', 'description': 'Natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit'},
    ],
  };

  render() {
    // throw new Error('Testing')
    return (
      <View style={styles.container}>
        <Swiper style={styles.wrapper} showsPagination={false} showsButtons={false} loop={true}>
          <ScrollView>      
            <View>
              {this.state.names.map((item, index) => (
                  <Accordian key = {item.id} style = {styles.item} name={item.name}
                  description={item.description} image={item.image} age={item.age}
                  icon={item.icon}>
                  </Accordian>
                ))
              }
            </View>
          </ScrollView>
          <View style={styles.container}>
            <ImageBackground source={background} resizeMode='cover' style={styles.imagebackground}>
              <View style={styles.logo}>
                <Image source={require('./media/Logos/CWI.png')} />
              </View>
            </ImageBackground>
          </View>
        </Swiper>
      </View>
    )
  };
}

class App extends Component {
  render() {
    return (
      <View style={styles.container}>
        <ErrorBoundary>
          <Header/>
          <Pages/>
        </ErrorBoundary>
      </View>
    )
  }
}

export default App

const styles = StyleSheet.create ({
  container: {
    flex: 1,
    justifyContent: 'center'
  },
  header: {
    height: 50,
    justifyContent:'center',
    backgroundColor:'#004F59',
  },
  headertext: {
    textAlign: 'center',
    fontSize: 20,
    color: 'white',
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
  imagebackground: {
    height: '100%',
    width:'100%',
  },
  logo: {
    justifyContent: 'center',
    alignItems: 'center',
    flex:1,
  }
});