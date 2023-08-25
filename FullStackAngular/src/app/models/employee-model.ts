export interface AddEmployeeRequest{
    empCode: number;
    name: string;
    phoneNo: string;
    address: string;
    departmentName: string;
    companyName: string;
    isApproved: number;
}


export interface EmployeeResponse{
    empCode: number;
    name: string;
    phoneNo: string;
    address: string;
    departmentName: string;
    companyName: string;
    isApproved: number;
}