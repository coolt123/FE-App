import React, { useState } from 'react';
import { View, Text, TextInput, Button, StyleSheet, Alert, TouchableOpacity } from 'react-native';
import { NavigationContainer } from '@react-navigation/native';
import 'react-native-gesture-handler';

import axios from 'axios';

const AddCompany = ({ navigation }) => {
  const [maSoThue, setMaSoThue] = useState('');
  const [tenCongTy, setTenCongTy] = useState('');
  const [viTriTuyenDung, setViTriTuyenDung] = useState('');
  const [yeuCauTuyenDung, setYeuCauTuyenDung] = useState('');
  const [diaChi, setDiaChi] = useState('');

  const validateInputs = () => {
    if (maSoThue.length < 20) {
      Alert.alert('Validation Error', 'Mã số thuế phải tối thiểu 20 ký tự');
      return false;
    }
    if (viTriTuyenDung.length < 10) {
      Alert.alert('Validation Error', 'Vị trí tuyển dụng tối thiểu 10 ký tự');
      return false;
    }
    if(tenCongTy.length < 30)
      {
        Alert.alert('Validation Error', 'Tên công ty tối thiểu 30 ký tự')
      }
      if (yeuCauTuyenDung.trim() === '') {
        Alert.alert('Validation Error', 'Yêu cầu tuyển dụng không được để trống');
        return false;
      }
      
    return true;
  };

  const HandleAddCompany = async () => {
    if (!validateInputs()) {
      return;
    }
    try {
      await axios.post('http://kiemtra.stecom.vn:8888/api/cong-viec/PKT0000466/create', {
        maSoThue ,
        tenCongTy ,
        viTriTuyenDung,
        yeuCauTuyenDung,
        diaChi
      });
      navigation.navigate('CompanyList',{refresh: true});
    } catch (error) {
      console.error(error);
    }
  };

  const confirmCancel = () => {
    Alert.alert(
      'Xác nhận',
      'Bạn có chắc chắn muốn hủy bỏ thêm mới hay không?',
      [
        { text: 'Không', style: 'cancel' },
        { text: 'Có', onPress: () => navigation.navigate('CompanyList',{refresh: true}) },
      ]
    );
  };

  return (
    <View style={styles.container}>
      <View style={styles.top} >
      <TouchableOpacity><Text>  </Text></TouchableOpacity>
        <Text style={styles.title}>Thêm công việc</Text>
      </View>
      
      <View>
        <Text > Mã số thuế</Text>
         <TextInput
        style={styles.input}
        placeholder="Nhập mã số thuế"
        value={maSoThue}
        onChangeText={setMaSoThue}
      />
      </View>
     
     <View>
      <Text> Tên công ty</Text>
      <TextInput
        style={styles.input}
        placeholder="Nhập tên công ty"
        value={tenCongTy}
        onChangeText={setTenCongTy}
      />
     </View>
      
      <View>
        <Text> Vị trí tuyển dụng</Text>
        <TextInput
        style={styles.input}
        placeholder="Nhập vị trí tuyển dụng"
        value={viTriTuyenDung}
        onChangeText={setViTriTuyenDung}
      />
      </View>
      
      <View>
        <Text> Yêu cầu tuyển dụng</Text>
        <TextInput
        style={styles.input}
        placeholder=""
        value={yeuCauTuyenDung}
        onChangeText={setYeuCauTuyenDung}
      />
      </View>
      
      <View>
      <Text>Địa chỉ</Text>
        <TextInput
        style={styles.input}
        placeholder="Địa Chỉ"
        value={diaChi}
        onChangeText={setDiaChi}
      />
      </View>
      
      <View style={styles.buttonContainer}>
        <Button title="Lưu lại" onPress={HandleAddCompany} />
        <Button title="Hủy bỏ" onPress={confirmCancel} />
      </View>
    </View>
  );
};

const styles = StyleSheet.create({
  container: {
    flex: 1,
    padding: 20,
    backgroundColor: '#fff',
  },
  title: {
    fontSize: 20,
    fontWeight: 'bold',
    marginBottom: 20,
  },
  input: {
    height: 40,
    borderColor: 'gray',
    borderWidth: 1,
    marginBottom: 20,
    paddingHorizontal: 10,
  },
  buttonContainer: {
    flexDirection: 'row',
    justifyContent: 'space-between',
  },
});

export default AddCompany;
