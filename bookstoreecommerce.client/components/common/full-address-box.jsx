"use client";

import { useEffect, useState } from "react";

import LocationSelection from "./location-selection";
import { getAllProvincesAction } from "@/actions/location-actions";
import {
  DEFAULT_PROVINCE,
  DEFAULT_DISTRICT,
  DEFAULT_WARD,
} from "@/lib/constant/constantData";
import {
  getDistrictByProvinceIdAction,
  getWardByDistrictIdAction,
} from "../../actions/location-actions";
import classes from "@/styles/common/full-address-bos.module.css";

export default function FullAddressBox() {
  const [provinces, setProvinces] = useState([DEFAULT_PROVINCE]);
  const [selectedProvince, setSelectedProvince] = useState(DEFAULT_PROVINCE);

  const [districts, setDistricts] = useState([DEFAULT_DISTRICT]);
  const [selectedDistrict, setSelectedDistrict] = useState(DEFAULT_DISTRICT);
  const [isDisabledDistrict, setIsDisabledDistrict] = useState(true);

  const [wards, setWards] = useState([DEFAULT_WARD]);
  const [selectedWard, setSelectedWard] = useState(DEFAULT_WARD);
  const [isDisabledWard, setIsDisabledWard] = useState(true);

  useEffect(() => {
    const fetchProvinces = async () => {
      const allProvinces = await getAllProvincesAction();
      setProvinces(allProvinces);
    };
    fetchProvinces();
  }, []);

  useEffect(() => {
    const fetchDistricts = async () => {
      if (selectedProvince.id != -1) {
        const allDistricts = await getDistrictByProvinceIdAction(
          selectedProvince.id
        );
        setDistricts(allDistricts);
        setSelectedDistrict(DEFAULT_DISTRICT);
        setIsDisabledDistrict(false);
        setIsDisabledWard(true);
      }
    };
    fetchDistricts();
  }, [selectedProvince]);

  useEffect(() => {
    const fetchWards = async () => {
      if (selectedProvince.id != -1) {
        const allWards = await getWardByDistrictIdAction(selectedDistrict.id);
        setWards(allWards);
        setSelectedWard(DEFAULT_WARD);
        setIsDisabledWard(false);
      }
    };
    fetchWards();
  }, [selectedDistrict]);

  return (
    <div className={classes.fullAddressBox}>
      <LocationSelection
        name="province"
        initOptions={provinces}
        selectedOption={selectedProvince}
        setSelectedOption={setSelectedProvince}
        disabled={false}
      />
      <LocationSelection
        name="district"
        initOptions={districts}
        selectedOption={selectedDistrict}
        setSelectedOption={setSelectedDistrict}
        disabled={isDisabledDistrict}
      />
      <LocationSelection
        name="ward"
        initOptions={wards}
        selectedOption={selectedWard}
        setSelectedOption={setSelectedWard}
        disabled={isDisabledWard}
      />
      <input type="text" placeholder="Address" name="address" />
    </div>
  );
}
