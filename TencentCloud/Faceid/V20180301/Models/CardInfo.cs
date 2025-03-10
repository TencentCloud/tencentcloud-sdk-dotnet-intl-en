/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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
        /// Hong Kong ID (China) Card
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HKIDCard")]
        public HKIDCard HKIDCard{ get; set; }

        /// <summary>
        /// Malaysia ID Card
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MLIDCard")]
        public MLIDCard MLIDCard{ get; set; }

        /// <summary>
        /// Philippines VoteID Card
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PhilippinesVoteID")]
        public PhilippinesVoteID PhilippinesVoteID{ get; set; }

        /// <summary>
        /// Indonesia ID Card
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IndonesiaIDCard")]
        public IndonesiaIDCard IndonesiaIDCard{ get; set; }

        /// <summary>
        /// Philippines Driving License
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PhilippinesDrivingLicense")]
        public PhilippinesDrivingLicense PhilippinesDrivingLicense{ get; set; }

        /// <summary>
        /// Philippines TinID
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PhilippinesTinID")]
        public PhilippinesTinID PhilippinesTinID{ get; set; }

        /// <summary>
        /// Philippines SSSID
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PhilippinesSSSID")]
        public PhilippinesSSSID PhilippinesSSSID{ get; set; }

        /// <summary>
        /// Philippines UMID
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PhilippinesUMID")]
        public PhilippinesUMID PhilippinesUMID{ get; set; }

        /// <summary>
        /// ID Cards of Hong Kong (China), Macao (China) and Taiwan (China), and International Passport
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InternationalIDPassport")]
        public InternationalIDPassport InternationalIDPassport{ get; set; }

        /// <summary>
        /// General license information
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("GeneralCard")]
        public GeneralCard GeneralCard{ get; set; }

        /// <summary>
        /// Indonesia Driving License
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IndonesiaDrivingLicense")]
        public IndonesiaDrivingLicense IndonesiaDrivingLicense{ get; set; }

        /// <summary>
        /// Thailand ID Card
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ThailandIDCard")]
        public ThailandIDCard ThailandIDCard{ get; set; }

        /// <summary>
        /// Singapore ID Card
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SingaporeIDCard")]
        public SingaporeIDCard SingaporeIDCard{ get; set; }

        /// <summary>
        /// Macao (China) ID Card
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MacaoIDCard")]
        public MacaoIDCard MacaoIDCard{ get; set; }

        /// <summary>
        /// TaiWan (China) ID Card
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaiWanIDCard")]
        public TaiWanIDCard TaiWanIDCard{ get; set; }

        /// <summary>
        /// Japan ID Card
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("JapanIDCard")]
        public JapanIDCard JapanIDCard{ get; set; }

        /// <summary>
        /// Bangladesh ID Card
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BangladeshIDCard")]
        public BangladeshIDCard BangladeshIDCard{ get; set; }

        /// <summary>
        /// Nigeria ID Card
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NigeriaIDCard")]
        public NigeriaIDCard NigeriaIDCard{ get; set; }

        /// <summary>
        /// Nigeria driving license
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NigeriaDrivingLicense")]
        public NigeriaDrivingLicense NigeriaDrivingLicense{ get; set; }

        /// <summary>
        /// Pakistan ID Card
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PakistanIDCard")]
        public PakistanIDCard PakistanIDCard{ get; set; }

        /// <summary>
        /// Pakistan driving license
        /// Note: This field may return null, indicating that no valid values can be obtained.
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

