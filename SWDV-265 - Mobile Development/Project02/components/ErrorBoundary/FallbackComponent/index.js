// @flow
import React, { type Node } from 'react'
import {
  SafeAreaView,
  Text,
  TouchableOpacity,
  View,
  StyleSheet
} from 'react-native'
import styles from './styles'
export type Props = { error: Error, resetError: Function }

const FallbackComponent = (props: Props): Node => (
  <SafeAreaView style={styles.container}>
    <View style={styles.content}>
      <Text style={styles.title}>Oops!</Text>
      <Text style={styles.subtitle}>{'There\'s an error'}</Text>
      <Text style={styles.error}>{props.error.toString()}</Text>
      <TouchableOpacity style={styles.button} onPress={props.resetError}>
        <Text style={styles.buttonText}>Try again</Text>
      </TouchableOpacity>
    </View>
  </SafeAreaView>
)

// const styles = StyleSheet.create({
//   container: {
//     backgroundColor: '#fafafa',
//     justifyContent: 'center'
//   },
//   content: {
//     marginHorizontal: 16
//   },
//   title: {
//     fontSize: 48,
//     fontWeight: '300',
//     paddingBottom: 16,
//     color: '#000'
//   },
//   subtitle: {
//     fontSize: 32,
//     fontWeight: '800',
//     color: '#000'
//   },
//   error: {
//     paddingVertical: 16
//   },
//   button: {
//     backgroundColor: '#2196f3',
//     borderRadius: 50,
//     padding: 16
//   },
//   buttonText: {
//     color: '#fff',
//     fontWeight: '600',
//     textAlign: 'center'
//   }
// })

export default FallbackComponent
