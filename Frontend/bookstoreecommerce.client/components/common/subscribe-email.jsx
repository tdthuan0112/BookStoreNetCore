import Image from "next/image";

import subscribeEmailImg from "@/assets/img/subscribeemail.png";

import classes from "@/styles/common/subscribe-email.module.css";
import { BTN_PRIMARY, LAYOUT_PRIMARY } from "@/lib/constant/constantCssName";

export default function SubscribeEmail() {
  return (
    <div className={classes.subscribeEmail}>
      <div className={LAYOUT_PRIMARY + classes.subcribeContent}>
        <Image src={subscribeEmailImg} width={350} alt="Subscribe Email" />
        <div>
          <p className={classes.title}>Subscribe to our newsletter</p>
          <form>
            <input
              type="text"
              id="email"
              name="email"
              placeholder="example@gmail.com"
              className={classes.input}
            ></input>
            <button className={BTN_PRIMARY + classes.button} type="submit">
              Subscribe
            </button>
          </form>
          <p className={classes.promise}>No spam, we promise</p>
        </div>
      </div>
    </div>
  );
}
