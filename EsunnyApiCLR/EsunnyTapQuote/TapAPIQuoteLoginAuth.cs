//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace TapQuoteWrapperApi
{
    /// <summary>
    /// ��¼��֤��Ϣ
    /// </summary>
    public class TapAPIQuoteLoginAuth : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal TapAPIQuoteLoginAuth(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIQuoteLoginAuth obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~TapAPIQuoteLoginAuth()
        {
            Dispose();
        }

        public virtual void Dispose()
        {
            lock (this)
            {
                if (swigCPtr.Handle != global::System.IntPtr.Zero)
                {
                    if (swigCMemOwn)
                    {
                        swigCMemOwn = false;
                        TapQuoteWrapperPINVOKE.delete_TapAPIQuoteLoginAuth(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }
        /// <summary>
        /// �û���
        /// </summary>
        public string UserNo
        {
            set
            {
                TapQuoteWrapperPINVOKE.TapAPIQuoteLoginAuth_UserNo_set(swigCPtr, value);
            }
            get
            {
                string ret = TapQuoteWrapperPINVOKE.TapAPIQuoteLoginAuth_UserNo_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// �Ƿ��޸����룬'Y'��ʾ�ǣ�'N'��ʾ��
        /// </summary>
        public char ISModifyPassword
        {
            set
            {
                TapQuoteWrapperPINVOKE.TapAPIQuoteLoginAuth_ISModifyPassword_set(swigCPtr, value);
            }
            get
            {
                char ret = TapQuoteWrapperPINVOKE.TapAPIQuoteLoginAuth_ISModifyPassword_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// �û�����
        /// </summary>
        public string Password
        {
            set
            {
                TapQuoteWrapperPINVOKE.TapAPIQuoteLoginAuth_Password_set(swigCPtr, value);
            }
            get
            {
                string ret = TapQuoteWrapperPINVOKE.TapAPIQuoteLoginAuth_Password_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// �����룬����������޸���������Ҫ��д���ֶ�
        /// </summary>
        public string NewPassword
        {
            set
            {
                TapQuoteWrapperPINVOKE.TapAPIQuoteLoginAuth_NewPassword_set(swigCPtr, value);
            }
            get
            {
                string ret = TapQuoteWrapperPINVOKE.TapAPIQuoteLoginAuth_NewPassword_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ������ʱ����
        /// </summary>
        public string QuoteTempPassword
        {
            set
            {
                TapQuoteWrapperPINVOKE.TapAPIQuoteLoginAuth_QuoteTempPassword_set(swigCPtr, value);
            }
            get
            {
                string ret = TapQuoteWrapperPINVOKE.TapAPIQuoteLoginAuth_QuoteTempPassword_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// �Ƿ���Ҫ��̬��֤��'Y'��ʾ�ǣ�'N'��ʾ��
        /// </summary>
        public char ISDDA
        {
            set
            {
                TapQuoteWrapperPINVOKE.TapAPIQuoteLoginAuth_ISDDA_set(swigCPtr, value);
            }
            get
            {
                char ret = TapQuoteWrapperPINVOKE.TapAPIQuoteLoginAuth_ISDDA_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        ///  ��̬��֤��
        /// </summary>
        public string DDASerialNo
        {
            set
            {
                TapQuoteWrapperPINVOKE.TapAPIQuoteLoginAuth_DDASerialNo_set(swigCPtr, value);
            }
            get
            {
                string ret = TapQuoteWrapperPINVOKE.TapAPIQuoteLoginAuth_DDASerialNo_get(swigCPtr);
                return ret;
            }
        }

        public TapAPIQuoteLoginAuth() : this(TapQuoteWrapperPINVOKE.new_TapAPIQuoteLoginAuth(), true)
        {
        }

    }

}