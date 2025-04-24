import { useState } from "react";

import classes from "@/styles/common/location-selection.module.css";

export default function LocationSelection({
  name,
  initOptions,
  selectedOption,
  setSelectedOption,
  disabled,
}) {
  const [isShowListOptions, setIsShowListOptions] = useState(false);
  function handleClickShowList(event) {
    event.preventDefault(0);
    setIsShowListOptions(!isShowListOptions);
  }

  return (
    <div className={classes.locationSelection}>
      <button
        className={`${classes.btnContainer} ${
          selectedOption.id > 0 ? classes.hasValue : undefined
        }`}
        onClick={handleClickShowList}
        disabled={disabled}
      >
        {selectedOption.value}
      </button>
      <input type="hidden" name={`${name}Id`} value={selectedOption.id} />
      <input type="hidden" name={`${name}Name`} value={selectedOption.value} />
      {isShowListOptions && (
        <CustomSelect
          initOptions={initOptions}
          setSelectedOption={setSelectedOption}
          setIsShowListOptions={setIsShowListOptions}
        />
      )}
    </div>
  );
}

function CustomSelect({
  initOptions,
  setSelectedOption,
  setIsShowListOptions,
}) {
  return (
    <div className={classes.customSelect}>
      <input
        className={classes.inputSearch}
        type="text"
        placeholder="Type to search"
      />
      <div className={classes.listOptions}>
        {initOptions.map((item) => (
          <p
            className={classes.optionItem}
            onClick={() => {
              setSelectedOption(item);
              setIsShowListOptions(false);
            }}
            key={item.id}
            value={item.value}
          >
            {item.value}
          </p>
        ))}
      </div>
    </div>
  );
}
