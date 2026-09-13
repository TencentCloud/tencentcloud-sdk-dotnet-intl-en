/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Rce.V20260130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReportEventRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Event code. Used to specify the scenario node for business access.</p><p> Standard events under the account protection product include:</p><ul><li> login: Log in<p></p></li> <li>register: Register </li><li>sms: SMS </li><li>logout: Log out </li><li>modify_account: Modify account </li><li>modify_password: Modify password </li><li>security_verification: Security verification</li></ul><p>Standard events under the payment protection product include:</p><ul><li>create_order: Create an order</li><li>transaction: Transaction</li><li>charge_back: Chargeback</li></ul><p>Standard events under the promotion protection product include:</p><ul><li>add_promotion: Participate in promotions </li><li>redeem: Redeem a prize </li><li>withdraw: Withdraw</li><li>cust_event: Custom event, cust_xxx </li><li>scan_code: Scan a code </li><li>lucky_draw: Lucky draw </li><li>task: Complete a task </li><li>invitation: Invitation </li><li>claim_red_packet: Receive a red packet </li><li>browse: Browse</li></ul><p>Custom events can be evaluated for risk based on an agreement with RCE</p>
        /// </summary>
        [JsonProperty("EventCode")]
        public string EventCode{ get; set; }

        /// <summary>
        /// <p>The time when the event occurred</p><p>Parameter format: Millisecond-level time with UTC time zone compliant with the ISO 8601 standard</p>
        /// </summary>
        [JsonProperty("EventTime")]
        public string EventTime{ get; set; }

        /// <summary>
        /// <p>The user's current session ID used to associate with the actions before and after logging in. If UserId is not passed, SessionId is required. If missing, an empty string can be filled.</p>
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// <p>The token provided by the SDK integrated in your web site or application</p>
        /// </summary>
        [JsonProperty("DeviceToken")]
        public string DeviceToken{ get; set; }

        /// <summary>
        /// <p>User client IP address (IPv4 or IPv6)</p>
        /// </summary>
        [JsonProperty("UserIp")]
        public string UserIp{ get; set; }

        /// <summary>
        /// <p>Event details, import corresponding event information based on the event code you input</p>
        /// </summary>
        [JsonProperty("EventDetail")]
        public EventDetail EventDetail{ get; set; }

        /// <summary>
        /// <p>The user's account ID in your system</p>
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// <p>Email of the user</p>
        /// </summary>
        [JsonProperty("UserEmail")]
        public string UserEmail{ get; set; }

        /// <summary>
        /// <p>Phone number of the user</p><p>Parameter format: Complies with the E.164 standard format, which includes "+", region code, and number</p>
        /// </summary>
        [JsonProperty("UserPhone")]
        public string UserPhone{ get; set; }

        /// <summary>
        /// <p>The details of the browser. If you've already integrated our device SDK, this field is not required</p>
        /// </summary>
        [JsonProperty("Browser")]
        public Browser Browser{ get; set; }

        /// <summary>
        /// <p>The details of the app, os and device.If you've already integrated our device SDK, this field is not required</p>
        /// </summary>
        [JsonProperty("App")]
        public App App{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EventCode", this.EventCode);
            this.SetParamSimple(map, prefix + "EventTime", this.EventTime);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "DeviceToken", this.DeviceToken);
            this.SetParamSimple(map, prefix + "UserIp", this.UserIp);
            this.SetParamObj(map, prefix + "EventDetail.", this.EventDetail);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "UserEmail", this.UserEmail);
            this.SetParamSimple(map, prefix + "UserPhone", this.UserPhone);
            this.SetParamObj(map, prefix + "Browser.", this.Browser);
            this.SetParamObj(map, prefix + "App.", this.App);
        }
    }
}

