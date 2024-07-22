import React, { useState, useEffect } from 'react';
import {
  FlatList,
  StyleSheet,
  Text,
  View,
  TextInput,
  Button,
  TouchableOpacity,
} from 'react-native';
import { NavigationContainer } from '@react-navigation/native';
import axios from 'axios';


const CompanyListScreen = ({ navigation }) => {
  const [list, setList] = useState([]);
  const [searchTerm, setSearchTerm] = useState('');
  const [displayedList, setDisplayedList] = useState([]);
  const [tempSearchTerm, setTempSearchTerm] = useState('');

  const getList = async () => {
    try {
      const response = await axios.get('http://kiemtra.stecom.vn:8888/api/cong-viec/PKT0000466/get-all');
      setList(response.data.items);
      setDisplayedList(response.data.items);
    } catch (error) {
      console.log(error);
    }
  };

  useEffect(() => {
    getList();
  }, []);

  const searchCompany = () => {
    if (!tempSearchTerm) {
      setDisplayedList(list);
    } else {
      const filteredList = list.filter((item) =>
        item.tenCongTy.toLowerCase().includes(tempSearchTerm.toLowerCase()) ||
        item.viTriTuyenDung.toLowerCase().includes(tempSearchTerm.toLowerCase())
      );
      setDisplayedList(filteredList);
    }
    setSearchTerm(tempSearchTerm);
  };
  
  return (
    <View style={styles.container}>
      <View style={styles.header}>
        <Text style={styles.title}>Danh sách công việc</Text>
        <Button title="+" onPress={() => navigation.navigate('AddCompany',{refresh: true})} />
      </View>
      <View style={styles.searchContainer}>
        <TextInput
          style={styles.searchInput}
          placeholder="Tìm kiếm"
          value={tempSearchTerm}
          onChangeText={(text) => setTempSearchTerm(text)}
        />
        <Button title="Tìm Kiếm" onPress={searchCompany} />
      </View>
      <FlatList
        data={displayedList}
        keyExtractor={(item) => item.id}
        renderItem={({ item }) => (
          <TouchableOpacity
            style={styles.itemContainer}
            onPress={() => navigation.navigate('CompanyDetail', { company: item })}
          >
            <Text style={styles.itemText}>{item.tenCongTy}</Text>
            <Text style={styles.itemText}>Vị trí : {item.viTriTuyenDung}</Text>
            <Text style={styles.itemText}>Địa chỉ :{item.diaChi}</Text>
          </TouchableOpacity>
        )}
      />
    </View>
  );
};

const styles = StyleSheet.create({
  container: {
    flex: 1,
    padding: 10,
    backgroundColor: '#fff',
  },
  header: {
    flexDirection: 'row',
    justifyContent: 'space-between',
    alignItems: 'center',
    paddingTop: 50,
    marginBottom: 20,
  },
  title: {
    fontSize: 20,
    fontWeight: 'bold',
  },
  searchContainer: {
    flexDirection: 'row',
    justifyContent: 'space-between',
    marginBottom: 20,
  },
  searchInput: {
    flex: 1,
    borderColor: 'gray',
    borderWidth: 1,
    padding: 10,
    marginRight: 10,
    borderRadius: 5,
  },
  itemContainer: {
    borderBottomWidth: 1,
    borderColor: 'gray',
    padding: 10,
    marginBottom: 10,
    borderRadius: 5,
    backgroundColor: '#f9f9f9',
  },
  itemText: {
    fontSize: 16,
  },
});

export default CompanyListScreen;
