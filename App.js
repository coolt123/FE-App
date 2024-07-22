import { StatusBar } from 'expo-status-bar';
import 'react-native-gesture-handler';
import { NavigationContainer } from '@react-navigation/native';
import { createStackNavigator } from '@react-navigation/stack';
import { StyleSheet, Text, View } from 'react-native';
import CompanyListScreen from './CompanyListScreen';
import AddCompany from './AddCompany';
import { createNativeStackNavigator } from '@react-navigation/native-stack';
import CompanyDetail from './CompanyDetail';
const Stack = createNativeStackNavigator();

export default function App() {
  return (
    
    <NavigationContainer>
    <Stack.Navigator>
      <Stack.Screen  name="Home" component={CompanyListScreen}   />
      <Stack.Screen name="AddCompany" component={AddCompany}  />
      <Stack.Screen name="CompanyList" component={CompanyListScreen}  />
      <Stack.Screen name="CompanyDetail" component={CompanyDetail}   />
      <Stack.Screen name="CompanyList2" component={CompanyListScreen}  />
    
    </Stack.Navigator>
  </NavigationContainer>
   
  );
}


