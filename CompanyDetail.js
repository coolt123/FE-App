import React from 'react';
import { View, Text, StyleSheet, Button, Alert } from 'react-native';
import axios from 'axios';

const CompanyDetail = ({ route, navigation }) => {
  const { company } = route.params;

  const deleteCompany = async () => {
    try {
      await axios.delete(`http://kiemtra.stecom.vn:8888/api/cong-viec/PKT0000466/${company.id}`);
      // Điều hướng quay lại màn hình danh sách sinh viên sau khi xóa thành công
      navigation.navigate('CompanyList2',{refresh: true});
    } catch (error) {
      console.error(error);
      Alert.alert('Lỗi', 'Không thể xóa công việc. Vui lòng thử lại sau.');
    }
  };

  // Hiển thị hộp thoại xác nhận xóa
  const confirmDelete = () => {
    Alert.alert(
      'Xóa công việc',
      'Bạn có chắc chắn muốn xóa công việc này không?',
      [
        { text: 'Hủy', style: 'cancel' },
        { text: 'Đồng ý', onPress: deleteCompany },
      ],
      { cancelable: true }
    );
  };

  return (
    <View style={styles.container}>
      <Text style={styles.title}>Thông Tin chi tiết công việc</Text>
      <View style={styles.detailItem}>
        <Text style={styles.label}>Mã số thuế:</Text>
        <Text>{company.maSoThue}</Text>
      </View>
      <View style={styles.detailItem}>
        <Text style={styles.label}>Tên công ty :</Text>
        <Text>{company.tenCongTy}</Text>
      </View>
      <View style={styles.detailItem}>
        <Text style={styles.label}>Vị trí tuyển dụng:</Text>
        <Text>{company.viTriTuyenDung}</Text>
      </View>
      <View style={styles.detailItem}>
        <Text style={styles.label}>Yêu cầu :</Text>
        <Text>{company.yeuCauTuyenDung}</Text>
      </View>
      <View style={styles.detailItem}>
        <Text style={styles.label}>Địa chỉ :</Text>
        <Text>{company.diaChi}</Text>
      </View>

      <Button title="Xóa công việc" onPress={confirmDelete} />
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
  detailItem: {
    marginBottom: 10,
  },
  label: {
    fontWeight: 'bold',
  },
});

export default CompanyDetail;
