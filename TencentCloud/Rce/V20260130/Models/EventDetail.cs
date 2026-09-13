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

    public class EventDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>Login</p>
        /// </summary>
        [JsonProperty("Login")]
        public LoginEvent Login{ get; set; }

        /// <summary>
        /// <p>Registration</p>
        /// </summary>
        [JsonProperty("Register")]
        public RegisterEvent Register{ get; set; }

        /// <summary>
        /// <p>Create an order</p>
        /// </summary>
        [JsonProperty("CreateOrder")]
        public CreateOrderEvent CreateOrder{ get; set; }

        /// <summary>
        /// <p>Transaction</p>
        /// </summary>
        [JsonProperty("Transaction")]
        public TransactionEvent Transaction{ get; set; }

        /// <summary>
        /// <p>SMS</p>
        /// </summary>
        [JsonProperty("Sms")]
        public SMSEvent Sms{ get; set; }

        /// <summary>
        /// <p>Chargeback</p>
        /// </summary>
        [JsonProperty("ChargeBack")]
        public ChargeBackEvent ChargeBack{ get; set; }

        /// <summary>
        /// <p>Logout</p>
        /// </summary>
        [JsonProperty("Logout")]
        public LogoutEvent Logout{ get; set; }

        /// <summary>
        /// <p>Modify account</p>
        /// </summary>
        [JsonProperty("ModifyAccount")]
        public ModifyAccountEvent ModifyAccount{ get; set; }

        /// <summary>
        /// <p>Modify password</p>
        /// </summary>
        [JsonProperty("ModifyPassword")]
        public ModifyPasswordEvent ModifyPassword{ get; set; }

        /// <summary>
        /// <p>Security verification</p>
        /// </summary>
        [JsonProperty("SecurityVerification")]
        public SecurityVerificationEvent SecurityVerification{ get; set; }

        /// <summary>
        /// <p>Participate in promotion activities</p>
        /// </summary>
        [JsonProperty("AddPromotion")]
        public AddPromotionEvent AddPromotion{ get; set; }

        /// <summary>
        /// <p>Redeem a prize</p>
        /// </summary>
        [JsonProperty("Redeem")]
        public RedeemEvent Redeem{ get; set; }

        /// <summary>
        /// <p>Withdrawal</p>
        /// </summary>
        [JsonProperty("Withdraw")]
        public WithdrawEvent Withdraw{ get; set; }

        /// <summary>
        /// <p>Custom event</p>
        /// </summary>
        [JsonProperty("CustEvent")]
        public CustEvent CustEvent{ get; set; }

        /// <summary>
        /// <p>Scan the QR code</p>
        /// </summary>
        [JsonProperty("ScanCode")]
        public ScanCodeEvent ScanCode{ get; set; }

        /// <summary>
        /// <p>Lucky draw</p>
        /// </summary>
        [JsonProperty("LuckyDraw")]
        public LuckyDrawEvent LuckyDraw{ get; set; }

        /// <summary>
        /// <p>Perform a task</p>
        /// </summary>
        [JsonProperty("Task")]
        public TaskEvent Task{ get; set; }

        /// <summary>
        /// <p>Invitation</p>
        /// </summary>
        [JsonProperty("Invitation")]
        public InvitationEvent Invitation{ get; set; }

        /// <summary>
        /// <p>Receive a red packet</p>
        /// </summary>
        [JsonProperty("ClaimRedPacket")]
        public ClaimRedPacketEvent ClaimRedPacket{ get; set; }

        /// <summary>
        /// <p>Browse</p>
        /// </summary>
        [JsonProperty("Browse")]
        public BrowseEvent Browse{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Login.", this.Login);
            this.SetParamObj(map, prefix + "Register.", this.Register);
            this.SetParamObj(map, prefix + "CreateOrder.", this.CreateOrder);
            this.SetParamObj(map, prefix + "Transaction.", this.Transaction);
            this.SetParamObj(map, prefix + "Sms.", this.Sms);
            this.SetParamObj(map, prefix + "ChargeBack.", this.ChargeBack);
            this.SetParamObj(map, prefix + "Logout.", this.Logout);
            this.SetParamObj(map, prefix + "ModifyAccount.", this.ModifyAccount);
            this.SetParamObj(map, prefix + "ModifyPassword.", this.ModifyPassword);
            this.SetParamObj(map, prefix + "SecurityVerification.", this.SecurityVerification);
            this.SetParamObj(map, prefix + "AddPromotion.", this.AddPromotion);
            this.SetParamObj(map, prefix + "Redeem.", this.Redeem);
            this.SetParamObj(map, prefix + "Withdraw.", this.Withdraw);
            this.SetParamObj(map, prefix + "CustEvent.", this.CustEvent);
            this.SetParamObj(map, prefix + "ScanCode.", this.ScanCode);
            this.SetParamObj(map, prefix + "LuckyDraw.", this.LuckyDraw);
            this.SetParamObj(map, prefix + "Task.", this.Task);
            this.SetParamObj(map, prefix + "Invitation.", this.Invitation);
            this.SetParamObj(map, prefix + "ClaimRedPacket.", this.ClaimRedPacket);
            this.SetParamObj(map, prefix + "Browse.", this.Browse);
        }
    }
}

