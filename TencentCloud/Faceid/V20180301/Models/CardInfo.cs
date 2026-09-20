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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CardInfo : AbstractModel
    {
        
        /// <summary>
        /// Hong Kong identity card
        /// </summary>
        [JsonProperty("HKIDCard")]
        public HKIDCard HKIDCard{ get; set; }

        /// <summary>
        /// Malaysian identity card
        /// </summary>
        [JsonProperty("MLIDCard")]
        public MLIDCard MLIDCard{ get; set; }

        /// <summary>
        /// Philippines voter card
        /// </summary>
        [JsonProperty("PhilippinesVoteID")]
        public PhilippinesVoteID PhilippinesVoteID{ get; set; }

        /// <summary>
        /// Indonesian Identity Card
        /// </summary>
        [JsonProperty("IndonesiaIDCard")]
        public IndonesiaIDCard IndonesiaIDCard{ get; set; }

        /// <summary>
        /// Philippines driving license
        /// </summary>
        [JsonProperty("PhilippinesDrivingLicense")]
        public PhilippinesDrivingLicense PhilippinesDrivingLicense{ get; set; }

        /// <summary>
        /// TinID in the Philippines
        /// </summary>
        [JsonProperty("PhilippinesTinID")]
        public PhilippinesTinID PhilippinesTinID{ get; set; }

        /// <summary>
        /// Philippines SSSID
        /// </summary>
        [JsonProperty("PhilippinesSSSID")]
        public PhilippinesSSSID PhilippinesSSSID{ get; set; }

        /// <summary>
        /// Philippines UMID
        /// </summary>
        [JsonProperty("PhilippinesUMID")]
        public PhilippinesUMID PhilippinesUMID{ get; set; }

        /// <summary>
        /// Hong Kong, Macao, and Taiwan region as well as overseas passport
        /// </summary>
        [JsonProperty("InternationalIDPassport")]
        public InternationalIDPassport InternationalIDPassport{ get; set; }

        /// <summary>
        /// General card certificate information
        /// </summary>
        [JsonProperty("GeneralCard")]
        public GeneralCard GeneralCard{ get; set; }

        /// <summary>
        /// Indonesian driving license
        /// </summary>
        [JsonProperty("IndonesiaDrivingLicense")]
        public IndonesiaDrivingLicense IndonesiaDrivingLicense{ get; set; }

        /// <summary>
        /// Thai Identity Card
        /// </summary>
        [JsonProperty("ThailandIDCard")]
        public ThailandIDCard ThailandIDCard{ get; set; }

        /// <summary>
        /// Singapore ID card
        /// </summary>
        [JsonProperty("SingaporeIDCard")]
        public SingaporeIDCard SingaporeIDCard{ get; set; }

        /// <summary>
        /// Macao (China) identity card
        /// </summary>
        [JsonProperty("MacaoIDCard")]
        public MacaoIDCard MacaoIDCard{ get; set; }

        /// <summary>
        /// Taiwan (China) ID card
        /// </summary>
        [JsonProperty("TaiWanIDCard")]
        public TaiWanIDCard TaiWanIDCard{ get; set; }

        /// <summary>
        /// Japan identity card
        /// </summary>
        [JsonProperty("JapanIDCard")]
        public JapanIDCard JapanIDCard{ get; set; }

        /// <summary>
        /// Bangladesh ID card
        /// </summary>
        [JsonProperty("BangladeshIDCard")]
        public BangladeshIDCard BangladeshIDCard{ get; set; }

        /// <summary>
        /// Nigerian Identity Card
        /// </summary>
        [JsonProperty("NigeriaIDCard")]
        public NigeriaIDCard NigeriaIDCard{ get; set; }

        /// <summary>
        /// Nigerian driver's license
        /// </summary>
        [JsonProperty("NigeriaDrivingLicense")]
        public NigeriaDrivingLicense NigeriaDrivingLicense{ get; set; }

        /// <summary>
        /// Pakistan identity card
        /// </summary>
        [JsonProperty("PakistanIDCard")]
        public PakistanIDCard PakistanIDCard{ get; set; }

        /// <summary>
        /// Pakistan driver's license
        /// </summary>
        [JsonProperty("PakistanDrivingLicense")]
        public PakistanDrivingLicense PakistanDrivingLicense{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "HKIDCard.", this.HKIDCard);
            this.SetParamObj(map, prefix + "MLIDCard.", this.MLIDCard);
            this.SetParamObj(map, prefix + "PhilippinesVoteID.", this.PhilippinesVoteID);
            this.SetParamObj(map, prefix + "IndonesiaIDCard.", this.IndonesiaIDCard);
            this.SetParamObj(map, prefix + "PhilippinesDrivingLicense.", this.PhilippinesDrivingLicense);
            this.SetParamObj(map, prefix + "PhilippinesTinID.", this.PhilippinesTinID);
            this.SetParamObj(map, prefix + "PhilippinesSSSID.", this.PhilippinesSSSID);
            this.SetParamObj(map, prefix + "PhilippinesUMID.", this.PhilippinesUMID);
            this.SetParamObj(map, prefix + "InternationalIDPassport.", this.InternationalIDPassport);
            this.SetParamObj(map, prefix + "GeneralCard.", this.GeneralCard);
            this.SetParamObj(map, prefix + "IndonesiaDrivingLicense.", this.IndonesiaDrivingLicense);
            this.SetParamObj(map, prefix + "ThailandIDCard.", this.ThailandIDCard);
            this.SetParamObj(map, prefix + "SingaporeIDCard.", this.SingaporeIDCard);
            this.SetParamObj(map, prefix + "MacaoIDCard.", this.MacaoIDCard);
            this.SetParamObj(map, prefix + "TaiWanIDCard.", this.TaiWanIDCard);
            this.SetParamObj(map, prefix + "JapanIDCard.", this.JapanIDCard);
            this.SetParamObj(map, prefix + "BangladeshIDCard.", this.BangladeshIDCard);
            this.SetParamObj(map, prefix + "NigeriaIDCard.", this.NigeriaIDCard);
            this.SetParamObj(map, prefix + "NigeriaDrivingLicense.", this.NigeriaDrivingLicense);
            this.SetParamObj(map, prefix + "PakistanIDCard.", this.PakistanIDCard);
            this.SetParamObj(map, prefix + "PakistanDrivingLicense.", this.PakistanDrivingLicense);
        }
    }
}

