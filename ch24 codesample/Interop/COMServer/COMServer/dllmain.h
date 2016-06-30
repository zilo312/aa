// dllmain.h : Declaration of module class.

class CCOMServerModule : public CAtlDllModuleT< CCOMServerModule >
{
public :
	DECLARE_LIBID(LIBID_COMServerLib)
	DECLARE_REGISTRY_APPID_RESOURCEID(IDR_COMSERVER, "{AAE6E5B4-65BC-452D-A068-8CFF5AF0083C}")
};

extern class CCOMServerModule _AtlModule;
